﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ClassifireOfDepartment
    {
        public long Id { get; set; }
        public int Level { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
    }
}
