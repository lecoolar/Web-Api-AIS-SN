﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class DiscountRequirement
    {
        public DiscountRequirement()
        {
            InverseParent = new HashSet<DiscountRequirement>();
        }

        public int Id { get; set; }
        public int DiscountId { get; set; }
        public string DiscountRequirementRuleSystemName { get; set; }
        public int? ParentId { get; set; }
        public int? InteractionTypeId { get; set; }
        public bool IsGroup { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual DiscountRequirement Parent { get; set; }
        public virtual ICollection<DiscountRequirement> InverseParent { get; set; }
    }
}
