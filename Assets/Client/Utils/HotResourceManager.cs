using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Client.MirGraphics;
using UnityEngine;
using UnityEngine.Networking;

namespace Client.Utils
{
    public sealed class HotResourceManager : MonoBehaviour
    {
        public static HotResourceManager Instance { get; private set; }

        public string BaseUrl = "";

        private readonly HashSet<string> _inProgress = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        private readonly Queue<(string relativePath, Action<bool> onComplete)> _pending = new Queue<(string, Action<bool>)>();
        private readonly HashSet<string> _pendingPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private readonly object _pendingLock = new object();
        private int _mainThreadId;

        private const int MaxFailCountPerFile = 2;
        private readonly Dictionary<string, int> _failCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        private readonly HashSet<string> _notFound = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        private const int MaxStartDownloadsPerFrame = 6;

        public int InProgressCount => _inProgress.Count;

        public int PendingCount
        {
            get
            {
                lock (_pendingLock)
                    return _pending.Count;
            }
        }

        public bool IsDownloading => InProgressCount > 0 || PendingCount > 0;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            _mainThreadId = Thread.CurrentThread.ManagedThreadId;

            if (string.IsNullOrWhiteSpace(BaseUrl))
                BaseUrl = Client.Settings.HotUpdateBaseUrl;

            if (!BaseUrl.EndsWith("/", StringComparison.Ordinal))
                BaseUrl += "/";
        }

        private void Update()
        {
            for (int i = 0; i < MaxStartDownloadsPerFrame; i++)
            {
                (string relativePath, Action<bool> onComplete) item;

                lock (_pendingLock)
                {
                    if (_pending.Count == 0) break;
                    item = _pending.Dequeue();
                    _pendingPaths.Remove(item.relativePath);
                }

                if (string.IsNullOrWhiteSpace(item.relativePath))
                {
                    item.onComplete?.Invoke(false);
                    continue;
                }

                if (_inProgress.Contains(item.relativePath))
                {
                    item.onComplete?.Invoke(true);
                    continue;
                }

                if (_notFound.Contains(item.relativePath))
                {
                    item.onComplete?.Invoke(false);
                    continue;
                }

                if (_failCount.TryGetValue(item.relativePath, out var queuedFails) && queuedFails >= MaxFailCountPerFile)
                {
                    item.onComplete?.Invoke(false);
                    continue;
                }

                _inProgress.Add(item.relativePath);
                StartCoroutine(DownloadCoroutine(item.relativePath, item.onComplete));
            }
        }

        private static string GetAlternateRelativePath(string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath)) return null;

            if (relativePath.StartsWith("Data/", StringComparison.Ordinal))
                return "data/" + relativePath.Substring("Data/".Length);

            if (relativePath.StartsWith("data/", StringComparison.Ordinal))
                return "Data/" + relativePath.Substring("data/".Length);

            if (relativePath.StartsWith("Map/", StringComparison.Ordinal))
                return "map/" + relativePath.Substring("Map/".Length);

            if (relativePath.StartsWith("map/", StringComparison.Ordinal))
                return "Map/" + relativePath.Substring("map/".Length);

            return null;
        }

        public void RequestFile(string relativePath, Action<bool> onComplete = null)
        {
            if (string.IsNullOrWhiteSpace(relativePath))
            {
                onComplete?.Invoke(false);
                return;
            }

            relativePath = relativePath.Replace('\\', '/').TrimStart('/');

            if (_notFound.Contains(relativePath))
            {
                onComplete?.Invoke(false);
                return;
            }

            if (Thread.CurrentThread.ManagedThreadId != _mainThreadId)
            {
                lock (_pendingLock)
                {
                    if (_inProgress.Contains(relativePath))
                    {
                        onComplete?.Invoke(true);
                        return;
                    }

                    if (_notFound.Contains(relativePath))
                    {
                        onComplete?.Invoke(false);
                        return;
                    }

                    if (_failCount.TryGetValue(relativePath, out var failCount) && failCount >= MaxFailCountPerFile)
                    {
                        onComplete?.Invoke(false);
                        return;
                    }

                    if (_pendingPaths.Add(relativePath))
                        _pending.Enqueue((relativePath, onComplete));
                }
                return;
            }

            if (_failCount.TryGetValue(relativePath, out var fails) && fails >= MaxFailCountPerFile)
            {
                onComplete?.Invoke(false);
                return;
            }

            if (_inProgress.Contains(relativePath))
            {
                onComplete?.Invoke(true);
                return;
            }

            _inProgress.Add(relativePath);
            StartCoroutine(DownloadCoroutine(relativePath, onComplete));
        }

        public void RequestMonsterLib(int index)
        {
            var file = index.ToString("000") + MLibrary.Extention;
            RequestFile("Data/Monster/" + file, ok =>
            {
                if (ok) Libraries.ReloadMonster(index);
            });
        }

        public void RequestNPCLib(int index)
        {
            var file = index.ToString("00") + MLibrary.Extention;
            RequestFile("Data/NPC/" + file, ok =>
            {
                if (ok) Libraries.ReloadNPC(index);
            });
        }

        public void RequestLibrary(MLibrary library)
        {
            if (library == null) return;

            var fullPath = library.FileName;
            if (string.IsNullOrWhiteSpace(fullPath)) return;

            try
            {
                var root = Path.GetFullPath(Client.Settings.resRootPath);
                var file = Path.GetFullPath(fullPath);

                if (!file.StartsWith(root, StringComparison.OrdinalIgnoreCase)) return;

                var relative = file.Substring(root.Length)
                    .TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                    .Replace(Path.DirectorySeparatorChar, '/');

                RequestFile(relative, ok =>
                {
                    if (ok) library.Reload();
                });
            }
            catch
            {
                // Ignore invalid paths.
            }
        }

        private IEnumerator DownloadCoroutine(string relativePath, Action<bool> onComplete)
        {
            var url = BaseUrl + relativePath;
            var localPath = Path.Combine(Client.Settings.resRootPath, relativePath.Replace('/', Path.DirectorySeparatorChar));

            Directory.CreateDirectory(Path.GetDirectoryName(localPath) ?? Client.Settings.resRootPath);

            var tempPath = localPath + ".tmp";

            bool TryValidateTempFile()
            {
                try
                {
                    var info = new FileInfo(tempPath);
                    return info.Exists && info.Length > 0;
                }
                catch
                {
                    return false;
                }
            }

            bool ok;
            bool notFound;
            using (var request = UnityWebRequest.Get(url))
            {
                request.downloadHandler = new DownloadHandlerFile(tempPath);
                yield return request.SendWebRequest();

                ok = request.result == UnityWebRequest.Result.Success && TryValidateTempFile();
                notFound = !ok && request.result != UnityWebRequest.Result.ConnectionError && request.result != UnityWebRequest.Result.DataProcessingError && request.responseCode == 404;
            }

            if (!ok && !notFound)
            {
                var alt = GetAlternateRelativePath(relativePath);
                if (!string.IsNullOrWhiteSpace(alt))
                {
                    var altUrl = BaseUrl + alt;
                    if (File.Exists(tempPath))
                    {
                        try { File.Delete(tempPath); } catch { }
                    }

                    using (var request = UnityWebRequest.Get(altUrl))
                    {
                        request.downloadHandler = new DownloadHandlerFile(tempPath);
                        yield return request.SendWebRequest();

                        ok = request.result == UnityWebRequest.Result.Success && TryValidateTempFile();

                        if (!ok && request.result != UnityWebRequest.Result.ConnectionError && request.result != UnityWebRequest.Result.DataProcessingError && request.responseCode == 404)
                        {
                            notFound = true;
                            _notFound.Add(alt);
                        }
                    }
                }
            }

            if (notFound)
            {
                _notFound.Add(relativePath);
                var alt = GetAlternateRelativePath(relativePath);
                if (!string.IsNullOrWhiteSpace(alt))
                    _notFound.Add(alt);
            }

            try
            {
                if (ok)
                {
                    if (File.Exists(localPath)) File.Delete(localPath);
                    File.Move(tempPath, localPath);

                    _failCount.Remove(relativePath);
                }
                else
                {
                    if (File.Exists(tempPath)) File.Delete(tempPath);

                    if (!notFound)
                    {
                        _failCount.TryGetValue(relativePath, out var fails);
                        _failCount[relativePath] = fails + 1;
                    }
                }
            }
            catch
            {
                ok = false;

                if (!notFound)
                {
                    _failCount.TryGetValue(relativePath, out var fails);
                    _failCount[relativePath] = fails + 1;
                }
            }
            finally
            {
                _inProgress.Remove(relativePath);
            }

            onComplete?.Invoke(ok);
        }
    }
}
