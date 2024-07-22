using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace HomeWork18
{
    class GetVideo : ICommand
    {
        Receiver receiver;
        YoutubeClient youtubeClient;

        public GetVideo(Receiver receiver, YoutubeClient youtubeClient)
        {
            this.receiver = receiver;
            this.youtubeClient = youtubeClient;
        }
        public async void Run()
        {
            var youtube = new YoutubeClient();
            var descriptionVideo = await youtube.Videos.GetAsync(receiver.adress);
            Console.WriteLine($"Название: {descriptionVideo.Title}");
            Console.WriteLine($"Продолжительность: {descriptionVideo.Duration}");
            Console.WriteLine($"Автор: {descriptionVideo.Author}");
        }
    }
}
