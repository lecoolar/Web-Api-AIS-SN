﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDocumentServiceTypesView
    {
        public long Id { get; set; }
        public long AccountdocumentId { get; set; }
        public long Servicetypeid { get; set; }
        public int? Servicetypecode { get; set; }
        public string Servicetypeshortname { get; set; }
        public string Servicetypelongname { get; set; }
    }
}
