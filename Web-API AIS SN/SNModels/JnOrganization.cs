﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnOrganization
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public long OrgId { get; set; }
        public long ServiceSplitDocumentId { get; set; }
        public long GroupOperId { get; set; }
        public decimal Summ { get; set; }
    }
}
