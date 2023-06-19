using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.YoutubeChannel_Folder.DATA
{
    public class Data_Shorts
    {
        public class Rootobject
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string nextPageToken { get; set; }
            public string regionCode { get; set; }
            public Pageinfo pageInfo { get; set; }
            public Item[] items { get; set; }
        }

        public class Pageinfo
        {
            public int totalResults { get; set; }
            public int resultsPerPage { get; set; }
        }

        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public Id id { get; set; }
        }

        public class Id
        {
            public string kind { get; set; }
            public string videoId { get; set; }
        }

    }
}
