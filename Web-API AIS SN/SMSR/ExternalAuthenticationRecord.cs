﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ExternalAuthenticationRecord
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string ExternalIdentifier { get; set; }
        public string ExternalDisplayIdentifier { get; set; }
        public string OauthToken { get; set; }
        public string OauthAccessToken { get; set; }
        public string ProviderSystemName { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
