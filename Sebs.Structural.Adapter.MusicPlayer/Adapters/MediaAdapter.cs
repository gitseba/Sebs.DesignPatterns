using Sebs.Structural.Adapter.MusicPlayer;

namespace Sebs.Structural.Adapter.MusicPlayer
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/27/2023 10:51:19 AM
    /// </summary>
    public class MediaAdapter : IMediaPlayerSimple
    {
        private readonly IMediaPlayerComplex _mediaPlayerComplex;

        public MediaAdapter(IMediaPlayerComplex mediaPlayerComplex)
        {
            _mediaPlayerComplex = mediaPlayerComplex;
        }

        public void Play(IMediaFormat format)
        {
            _mediaPlayerComplex.Play(format);
        }
    }
}
