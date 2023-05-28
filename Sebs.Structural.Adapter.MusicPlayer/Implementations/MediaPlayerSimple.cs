using Sebs.Structural.Adapter.MusicPlayer;

namespace Sebs.Structural.Adapter.MusicPlayer
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/27/2023 10:52:51 AM
    /// </summary>
    public class MediaPlayerSimple : IMediaPlayerSimple
    {
        public void Play(IMediaFormat format)
        {
            if(format.Name != ".mp3")
            {
                //throw new NotSupportedException("Media format is not supported by simple media player!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Media player simple: Media format {format.Name} is not supported by this media player! Consider using Media player complex.");
                Console.ForegroundColor = ConsoleColor.White;

                return;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Media player simple: Run {format.Name} file format.");
        }
    }
}
