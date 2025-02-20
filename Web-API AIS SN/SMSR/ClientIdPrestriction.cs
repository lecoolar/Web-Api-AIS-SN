﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ClientIdPrestriction
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Provider { get; set; }

        public virtual Client Client { get; set; }
    }
}
