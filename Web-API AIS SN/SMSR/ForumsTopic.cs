﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ForumsTopic
    {
        public ForumsTopic()
        {
            ForumsPosts = new HashSet<ForumsPost>();
        }

        public int Id { get; set; }
        public int ForumId { get; set; }
        public int CustomerId { get; set; }
        public int TopicTypeId { get; set; }
        public string Subject { get; set; }
        public int NumPosts { get; set; }
        public int Views { get; set; }
        public int LastPostId { get; set; }
        public int LastPostCustomerId { get; set; }
        public DateTime? LastPostTime { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ForumsForum Forum { get; set; }
        public virtual ICollection<ForumsPost> ForumsPosts { get; set; }
    }
}
