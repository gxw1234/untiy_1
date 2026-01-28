using System;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

namespace Client.MirSounds.Libraries
{
    internal class NAudioLibrary : ISoundLibrary, IDisposable
    {
        private GameObject MirAudioSource;
        private AudioClip audioClip;
        private AudioSource audioSource;
        public int Index { get; set; }
        public long ExpireTime { get; set; }

        //private List<SecondarySoundBuffer> _bufferList;
        //private WaveStream _stream;

        private bool _loop;

        //private SoundBufferDescription _desc;
        private readonly byte[] _data;

        public static NAudioLibrary TryCreate(int index, string fileName, bool loop)
        {
            if (!fileName.Contains(".wav") && !fileName.Contains(".wav"))
                fileName = fileName + ".wav";

            fileName = Path.Combine(Settings.SoundPath, fileName);
            if (File.Exists(fileName))
            {
                return new NAudioLibrary(index, fileName, loop);
            }

            return null;
        }

        public NAudioLibrary(int index, string fileName, bool loop)
        {
            MirAudioSource = MirObjectPool.Instance().GetObjectFromPool(MirControlEnum.MirAudioSource);

            Index = index;
            _loop = loop;

            UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip("file://" + Path.GetFullPath(fileName), AudioType.WAV);
            www.SendWebRequest();

            while (!www.isDone)
            {
                // 等待请求完成
            }

            if (www.result == UnityWebRequest.Result.Success)
            {
                // 获取加载的音频数据
                audioClip = DownloadHandlerAudioClip.GetContent(www);
            }
            else
            {
                Debug.LogError("Error loading audio file: " + www.error);
            }

            www.Dispose(); // 释放资源

            Play();
        }

        public void Play()
        {
            if (audioClip == null) return;

            audioSource = MirAudioSource.GetComponent<AudioSource>();
            audioSource.clip = audioClip;
            audioSource.loop = _loop;
            audioSource.Play();
        }

        public void Stop()
        {
            if (MirAudioSource == null) return;

            AudioSource audioSource = MirAudioSource.GetComponent<AudioSource>();
            audioSource.Stop();
        }

        public void Dispose()
        {
            if (MirAudioSource != null)
                MirObjectPool.Instance().ReturnObjectToPool(MirControlEnum.MirAudioSource, MirAudioSource);
            MirAudioSource = null;
            _loop = false;
        }

        public void SetVolume(float vol)
        {
            audioSource.volume = vol / 100 != 0 ? vol / 100 : 0.1f;
        }

        public bool IsPlaying()
        {
            return audioSource.isPlaying;
        }

        public void Play(float volume)
        {
            Play();
        }
    }
}
