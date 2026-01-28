namespace Client.MirSounds
{
	public interface ISoundLibrary
    {
        int Index { get; set; }
        long ExpireTime { get; set; }

        bool IsPlaying();
        void Play(float volume);
        void Stop();
        void SetVolume(float vol);

        void Dispose();
    }
}
