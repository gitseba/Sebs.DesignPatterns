namespace Sebs.Structural.Adapter.MusicPlayer
{
    /// <summary>
    /// The Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to work together. 
    /// It acts as a bridge between two incompatible interfaces, converting the interface of one class into another interface that clients expect.
    /// 
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Description: We have a simple media player that knows only to play .mp3 media format. 
            //              At some point the customers ask for playing .vlc media format also.
            //              For this to happen we create another class that can extend format playing options (MediaPlayerComplex.cs)

            /*********************** MEDIA PLAYER Simple ******************************/

            // Create formats 
            var mediaFormatList = new List<IMediaFormat>
            {
                new Mp3Format(),
                new VlcFormat(),
                new Mp4Format()
            };

            var mediaPlayerSimple = new MediaPlayerSimple();
            foreach (var format in mediaFormatList)
            {
                mediaPlayerSimple.Play(format);
            }

            Console.WriteLine("\nAdapt Simple Media Player to Complex Media PLayer!\n");
            /*********************** MEDIA PLAYER Complex ******************************/

            // Create a media player complex object
            var mediaPLayerComplex = new MediaPlayerComplex();

            // In order to play the media player complex with extended functionality options
            // we need to create an adapter between interfaces (IMediaPlayerSimple & IMediaPlayerComplex)
            IMediaPlayerSimple mediaPlayerSimpleAdapter = new MediaAdapter(mediaPLayerComplex);

            // Now when I use the media player simple play method, 
            // the adapter will switch to media player complex and run the extended functionality
            foreach (var format in mediaFormatList)
            {
                mediaPlayerSimpleAdapter.Play(format);
            }

            Console.ReadLine();
        }
    }
}