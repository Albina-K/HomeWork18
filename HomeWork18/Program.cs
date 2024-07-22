using YoutubeExplode;

namespace HomeWork18
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver("https://www.youtube.com/watch?v=_kT_MbdRkRk");
            YoutubeClient youtubeClient = new YoutubeClient();
            YouTubeCommand youtubeCommand = new YouTubeCommand();

            GetVideo getVideo = new GetVideo(receiver, youtubeClient);
            youtubeCommand.SetCommand(getVideo);
            youtubeCommand.Run();

            DownloadVideo downloadVideo = new DownloadVideo(receiver, youtubeClient);
            youtubeCommand.SetCommand(downloadVideo);
            youtubeCommand.Run();

            Console.ReadKey();
        }
    }
}