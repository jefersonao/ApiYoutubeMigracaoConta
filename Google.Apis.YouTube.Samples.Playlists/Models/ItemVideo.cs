using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Apis.YouTube.Samples.Models
{
    public class ItemVideo
    {

        public ContentDetails contentDetails { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public string kind { get; set; }
        public Snippet snippet { get; set; }
        public Status status { get; set; }
    }

    public class ContentDetails
    {
        public string videoId { get; set; }
        public DateTime videoPublishedAt { get; set; }
    }

    public class ResourceId
    {
        public string kind { get; set; }
        public string videoId { get; set; }
    }

    public class Default
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class High
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class Maxres
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class Medium
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class Standard
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class Thumbnails
    {
        public Default @default { get; set; }
        public High high { get; set; }
        public Maxres maxres { get; set; }
        public Medium medium { get; set; }
        public Standard standard { get; set; }
    }

    public class Snippet
    {
        public string channelId { get; set; }
        public string channelTitle { get; set; }
        public string description { get; set; }
        public string playlistId { get; set; }
        public int position { get; set; }
        public DateTime publishedAt { get; set; }
        public ResourceId resourceId { get; set; }
        public Thumbnails thumbnails { get; set; }
        public string title { get; set; }
    }

    public class Status
    {
        public string privacyStatus { get; set; }
    }

}
