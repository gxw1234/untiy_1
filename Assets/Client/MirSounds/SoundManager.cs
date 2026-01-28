using System.Collections.Generic;
using System.IO;
using Client.MirSounds.Libraries;
using System.Linq;
namespace Client.MirSounds
{
    static class SoundManager
    {
        private static readonly List<ISoundLibrary> Sounds = new List<ISoundLibrary>();
        public static readonly Dictionary<int, string> IndexList = new Dictionary<int, string>();
        public static List<string> IndexListNO = new List<string>();
        private static readonly List<KeyValuePair<long, int>> DelayList = new List<KeyValuePair<long, int>>();

        public static readonly List<string> SupportedFileTypes;

        public static ISoundLibrary Music;
        private static long _checkSoundTime;

        private static float _vol;
        public static float Vol
        {
            get { return _vol; }
            set
            {
                if (_vol == value) return;
                _vol = value;
                AdjustAllVolumes();
            }
        }

        private static float _musicVol;
        public static float MusicVol
        {
            get { return _musicVol; }
            set
            {
                if (_musicVol == value) return;
                _musicVol = value;
                AdjustMusicVolume();
            }
        }

        static SoundManager()
        {
            SupportedFileTypes = new List<string>
            {
                ".wav",
                ".mp3"
            };
        }

        public static void ProcessDelayedSounds()
        {
            if (DelayList.Count == 0) return;

            var sounds = DelayList.Where(x => x.Key <= CMain.Time).ToList();

            foreach (var sound in sounds)
            {
                DelayList.Remove(sound);

                PlaySound(sound.Value);
            }
        }

        public static void Create()
        {
            LoadSoundList();
        }

        public static void LoadSoundList()
        {
            string fileName = Path.Combine(Settings.SoundPath, "SoundList.lst");

            if (!File.Exists(fileName))
            {
                // if (Settings.真微端)
                //     AsynDownLoadResources.CreateInstance().Add(fileName, LoadSoundList);
                UnityEngine.Debug.Log(fileName + " 资源不存在");
                return;
            }

            string[] lines = File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Replace(" ", "").Split(':', '\t');

                int index;
                if (split.Length <= 1 || !int.TryParse(split[0], out index)) continue;

                if (!IndexList.ContainsKey(index))
                    IndexList.Add(index, split[split.Length - 1]);
            }
            LoadSoundListNO();
        }
        public static void LoadSoundListNO()
        {
            string fileName = Path.Combine(Settings.SoundPath, "SoundListNO.lst");

            if (!File.Exists(fileName))
            {
                IndexListNO.Add("000-0");
                // if (Settings.真微端)
                // {
                //     AsynDownLoadResources.CreateInstance().Add(fileName, LoadSoundListNO);
                // }
                UnityEngine.Debug.Log(fileName + " 资源不存在");
                return;
            }

            string[] lines = File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i++)
            {
                string split = lines[i].Replace(" ", "");
                IndexListNO.Add(split);
            }

        }
        public static void StopSound(int index)
        {
            for (int i = 0; i < Sounds.Count; i++)
            {
                if (Sounds[i].Index != index) continue;

                Sounds[i].Stop();
                return;
            }
        }

        public static void PlaySound(int index, bool loop = false, int delay = 0)
        {
            if (delay > 0)
            {
                DelayList.Add(new KeyValuePair<long, int>(CMain.Time + delay, index));
                return;
            }

            CheckSoundTimeOut();

            for (int i = 0; i < Sounds.Count; i++)
            {
                if (Sounds[i].Index != index) continue;
                Sounds[i].Play(Vol);
                return;
            }

            if (IndexList.ContainsKey(index))
                Sounds.Add(GetSound(index, IndexList[index], Vol, loop));
            else
            {
                string filename;
                if (index > 20000)
                {
                    index -= 20000;
                    filename = string.Format("M{0:0}-{1:0}", index / 10, index % 10);
                    if (!IndexListNO.Contains(filename))
                        Sounds.Add(GetSound(index + 20000, filename, Vol, loop));
                }
                else if (index < 10000)
                {
                    filename = string.Format("{0:000}-{1:0}", index / 10, index % 10);
                    if (!IndexListNO.Contains(filename))
                        Sounds.Add(GetSound(index, filename, Vol, loop));
                }
            }
        }

        public static void PlayMusic(int index, bool loop = false)
        {
            if (IndexList.TryGetValue(index, out string value))
            {
                Music = GetSound(index, value, MusicVol, loop);
            }
        }

        public static void StopMusic()
        {
            Music?.Stop();
            Music?.Dispose();
        }

        static void AdjustMusicVolume()
        {
            Music?.SetVolume(MusicVol);
        }

        static void AdjustAllVolumes()
        {
            for (int i = 0; i < Sounds.Count; i++)
            {
                Sounds[i].SetVolume(Vol);
            }
        }

        static void CheckSoundTimeOut()
        {
            if (CMain.Time >= _checkSoundTime)
            {
                _checkSoundTime = CMain.Time + 30 * 1000;

                for (int i = Sounds.Count - 1; i >= 0; i--)
                {
                    var sound = Sounds[i];

                    if (!sound.IsPlaying())
                    {
                        if (CMain.Time >= sound.ExpireTime)
                        {
                            sound.Dispose();
                            Sounds.RemoveAt(i);
                            continue;
                        }
                    }
                }
            }
        }

        static ISoundLibrary GetSound(int index, string fileName, float volume, bool loop)
        {
            var sound = NAudioLibrary.TryCreate(index, Path.Combine(Settings.SoundPath, fileName), loop);
            if (sound != null)
            {
                return sound;
            }

            IndexListNO.Add(fileName);
            return sound == null ? new NullLibrary(index, fileName, loop) : sound;
        }

        public static void Dispose()
        {
            DelayList.Clear();

            for (int i = Sounds.Count - 1; i >= 0; i--)
            {
                Sounds[i]?.Dispose();
            }

            Music?.Dispose();
        }
    }


}
