﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplateSettingBlock
    {
        public NoticeTemplateSettingBlock()
        {
            NoticeTemplateSettingBlockParameters = new HashSet<NoticeTemplateSettingBlockParameter>();
        }

        public long Id { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public string Name { get; set; }

        public virtual NoticeTemplateSetting NoticeTemplateSetting { get; set; }
        public virtual ICollection<NoticeTemplateSettingBlockParameter> NoticeTemplateSettingBlockParameters { get; set; }
    }
}
