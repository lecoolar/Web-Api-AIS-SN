﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RightType
    {
        public RightType()
        {
            Rights = new HashSet<Right>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Right> Rights { get; set; }
    }
}
