using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApp.Models
{
    public class Post
    {
        public string id { get; set; }
        public string uuid { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public string html { get; set; }
        public string comment_id { get; set; }
        public string feature_image { get; set; }
        public bool featured { get; set; }
        public string visibility { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime published_at { get; set; }
        public string custom_excerpt { get; set; }
        public string codeinjection_head { get; set; }
        public object codeinjection_foot { get; set; }
        public object custom_template { get; set; }
        public object canonical_url { get; set; }
        public string url { get; set; }
        public string excerpt { get; set; }
        public int reading_time { get; set; }
        public bool access { get; set; }
        public object og_image { get; set; }
        public object og_title { get; set; }
        public object og_description { get; set; }
        public object twitter_image { get; set; }
        public object twitter_title { get; set; }
        public object twitter_description { get; set; }
        public string meta_title { get; set; }
        public string meta_description { get; set; }
        public object email_subject { get; set; }
        public object frontmatter { get; set; }
        public object feature_image_alt { get; set; }
        public object feature_image_caption { get; set; }
        public string plaintext { get; set; }
    }
}
