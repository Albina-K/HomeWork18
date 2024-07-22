using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace HomeWork18
{
    class DownloadVideo : ICommand
    {
        Receiver receiver;
        YoutubeClient youtubeClient;

        public DownloadVideo(Receiver receiver, YoutubeClient youtubeClient)
        {
            this.receiver = receiver;
            this.youtubeClient = youtubeClient;
        }
        public async void Run()
        {   
          
            var youtube = new YoutubeClient();
            var videoName = await youtube.Videos.GetAsync(receiver.adress);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(receiver.adress);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            var fileName = $"{videoName.Title}.{streamInfo.Container}";
            string path = @"C:\Users\gsu\Desktop";
            var filePath = Path.Combine(path, fileName);
            await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath);
        }
    }
}
