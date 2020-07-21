using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Apis.YouTube.Samples.Models
{

    public class inscricao
    {
        public ContentDetails contentDetails { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public string kind { get; set; }
        public Snippet snippet { get; set; }
    }

    public class inscricoesContentDetails
    {
        public string activityType { get; set; }
        public int newItemCount { get; set; }
        public int totalItemCount { get; set; }
    }

    public class inscricoesResourceId
    {
        public string channelId { get; set; }
        public string kind { get; set; }
    }

    public class inscricoesDefault
    {
        public string url { get; set; }
    }

    public class inscricoesHigh
    {
        public string url { get; set; }
    }

    public class inscricoesMedium
    {
        public string url { get; set; }
    }

    public class inscricoesThumbnails
    {
        public Default @default { get; set; }
        public High high { get; set; }
        public Medium medium { get; set; }
    }

    public class inscricoesSnippet
    {
        public string channelId { get; set; }
        public string description { get; set; }
        public DateTime publishedAt { get; set; }
        public ResourceId resourceId { get; set; }
        public Thumbnails thumbnails { get; set; }
        public string title { get; set; }
    }


}
