﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class GdprLog
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ConsentId { get; set; }
        public string CustomerInfo { get; set; }
        public int RequestTypeId { get; set; }
        public string RequestDetails { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
