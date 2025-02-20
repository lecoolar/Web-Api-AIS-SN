﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }
        public string DisplayLocale { get; set; }
        public string CustomFormatting { get; set; }
        public bool LimitedToStores { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int RoundingTypeId { get; set; }
    }
}
