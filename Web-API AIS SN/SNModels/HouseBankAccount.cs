﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseBankAccount
    {
        public HouseBankAccount()
        {
            HouseBankAccountServiceTypes = new HashSet<HouseBankAccountServiceType>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long HouseId { get; set; }
        public long BankAccountId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TypeId { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual House House { get; set; }
        public virtual ICollection<HouseBankAccountServiceType> HouseBankAccountServiceTypes { get; set; }
    }
}
