namespace DownLoadYouTube {
    class Program {
        static async Task Main (string[] args) {
            var user = new User();
            // создадим получателя
            var Downloader = new YoutubeDownloader("https://www.youtube.com/watch?v=oIS1dac5lKg");

            //запрос информации
            var GetInfo = new GetAsync(Downloader);
            user.SetCommand(GetInfo);
            await user.Run();

            //загрузка
            var download = new DownloadAsync(Downloader);
            user.SetCommand(download);
            await user.Run();
        }
    }
}