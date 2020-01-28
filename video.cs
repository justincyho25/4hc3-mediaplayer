using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWMSMediaPlayer
{
    class video
    {
        private static string filePath;
        private static string currentVideo;

        public static void setPath(string p)
        {
            video.filePath = p;
        }

        public static string getPath()
        {
            return video.filePath;
        }

        public static void setSelectedVideo(string p)
        {
            video.currentVideo = p;
        }

        public static string getSelectedVideo()
        {
            return video.currentVideo;
        }

    }
}
