using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownLoadYouTube {
    class DownloadAsync : Command {
        YoutubeDownloader downloader;
        public DownloadAsync (YoutubeDownloader downloader) {
            this.downloader = downloader;
        }

        public override async Task Run () {
            await downloader.Download();
        }
    }
}
