﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ApiResource
    {
        public ApiResource()
        {
            ApiClaims = new HashSet<ApiClaim>();
            ApiScopes = new HashSet<ApiScope>();
            ApiSecrets = new HashSet<ApiSecret>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApiClaim> ApiClaims { get; set; }
        public virtual ICollection<ApiScope> ApiScopes { get; set; }
        public virtual ICollection<ApiSecret> ApiSecrets { get; set; }
    }
}
