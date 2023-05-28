using Sebs.Structural.Adapter.MusicPlayer;

namespace Sebs.Structural.Adapter.MusicPlayer
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/27/2023 11:14:38 AM
    /// </summary>
    public class MediaPlayerComplex : IMediaPlayerComplex
    {
        public void Play(IMediaFormat format)
        {
            Console.WriteLine($"Media player complex: Run {format.Name} file format.");
        }
    }
}
