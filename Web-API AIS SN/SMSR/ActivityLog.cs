﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ActivityLog
    {
        public int Id { get; set; }
        public int ActivityLogTypeId { get; set; }
        public int? EntityId { get; set; }
        public string EntityName { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string IpAddress { get; set; }

        public virtual ActivityLogType ActivityLogType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
