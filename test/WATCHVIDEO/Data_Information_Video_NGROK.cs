using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Data_Information_Video_NGROK
    {

        public class Rootobject
        {
            public Thumbnails thumbnails { get; set; }
            public string _id { get; set; }
            public string videoId { get; set; }
            public string etag { get; set; }
            public string title { get; set; }
            public string channelId { get; set; }
            public string channelTitle { get; set; }
            public DateTime publishTime { get; set; }
            public int __v { get; set; }
        }

        public class Thumbnails
        {
            public Default _default { get; set; }
            public Medium medium { get; set; }
            public High high { get; set; }
        }

        public class Default
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Medium
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class High
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

    }
}
