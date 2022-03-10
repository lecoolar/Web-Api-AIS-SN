﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class FavoriteReportTemplate
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ReportTemplateId { get; set; }

        public virtual ReportTemplate ReportTemplate { get; set; }
        public virtual User User { get; set; }
    }
}
