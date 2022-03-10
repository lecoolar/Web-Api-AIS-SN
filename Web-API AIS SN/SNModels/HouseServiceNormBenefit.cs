﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceNormBenefit
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long ServiceTypeId { get; set; }
        public long? ServiceId { get; set; }
        public long BenefitId { get; set; }
        public decimal Rate { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }

        public virtual Benefit1 Benefit { get; set; }
        public virtual House House { get; set; }
        public virtual Service1 Service { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
