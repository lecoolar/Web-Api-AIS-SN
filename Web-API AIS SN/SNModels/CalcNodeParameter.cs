﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcNodeParameter
    {
        public long CalcNodeId { get; set; }
        public string ParamName { get; set; }
        public string Paramvalue { get; set; }
    }
}
