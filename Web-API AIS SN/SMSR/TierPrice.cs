﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class TierPrice
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int? CustomerRoleId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime? StartDateTimeUtc { get; set; }
        public DateTime? EndDateTimeUtc { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }
        public virtual Product Product { get; set; }
    }
}
