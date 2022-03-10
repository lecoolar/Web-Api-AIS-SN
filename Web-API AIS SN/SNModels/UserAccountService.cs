﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserAccountService
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long AccountId { get; set; }
        public long AccountServiceId { get; set; }

        public virtual Account Account { get; set; }
        public virtual User User { get; set; }
    }
}
