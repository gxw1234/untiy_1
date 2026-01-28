using System;
namespace Client.MirSounds
{
	public class NullLibrary : ISoundLibrary, IDisposable
    {
        public int Index { get; set; }
        public string FileName { get; set; }
        public bool Loop { get; set; }
        public long ExpireTime { get; set; }

        public NullLibrary(int index, string fileName, bool loop)
        {
            Index = index;
            FileName = fileName;
            Loop = loop;
        }

        public void Dispose()
        {
        }

        public bool IsPlaying()
        {
            return false;
        }

        public void Play(float volume)
        {
        }

        public void SetVolume(float vol)
        {
        }

        public void Stop()
        {
        }
    }
}
