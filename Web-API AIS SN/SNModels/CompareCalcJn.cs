﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CompareCalcJn
    {
        public int CompareNum { get; set; }
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public decimal Summ { get; set; }
        public byte CalcOperId { get; set; }
        public long? GroupOperId { get; set; }
    }
}
