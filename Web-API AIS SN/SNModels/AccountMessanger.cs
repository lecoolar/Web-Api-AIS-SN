﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountMessanger
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string PhoneNumber { get; set; }
        public string TelegramChatId { get; set; }
        public string ViberChatId { get; set; }
    }
}
