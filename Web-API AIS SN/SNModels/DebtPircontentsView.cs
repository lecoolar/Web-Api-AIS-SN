﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtPircontentsView
    {
        public long Id { get; set; }
        public int? TypePir { get; set; }
        public string TypePirname { get; set; }
        public int? TypePirperiod { get; set; }
        public string TypePirperiodName { get; set; }
        public DateTime? Created { get; set; }
    }
}
