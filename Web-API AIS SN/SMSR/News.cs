﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class News
    {
        public News()
        {
            NewsComments = new HashSet<NewsComment>();
        }

        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Short { get; set; }
        public string Full { get; set; }
        public bool Published { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public bool AllowComments { get; set; }
        public bool LimitedToStores { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
    }
}
