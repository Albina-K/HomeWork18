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
        public async Task Run()
        {   
        
            var youtube = new YoutubeClient();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(receiver.adress);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}
