﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ResultAccountNotice
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public long? ActionId { get; set; }
        public long? SpecificData { get; set; }

        public virtual Action Action { get; set; }
        public virtual NoticeTemplateSetting NoticeTemplateSetting { get; set; }
    }
}
