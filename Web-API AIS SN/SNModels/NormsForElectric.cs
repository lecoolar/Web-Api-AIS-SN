﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NormsForElectric
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public int FromResidents { get; set; }
        public int ToResidents { get; set; }
        public int FromRooms { get; set; }
        public int ToRooms { get; set; }
        public decimal FromSquare { get; set; }
        public decimal ToSquare { get; set; }
        public int IsWithCooker { get; set; }
        public int IsWithLift { get; set; }
        public decimal Value { get; set; }
        public int? ApartmentTypeId { get; set; }
        public bool IsMop { get; set; }
        public int IsWithHeater { get; set; }
        public bool UseMop { get; set; }
        public long? ServiceId { get; set; }
        public int IsDayNightCounter { get; set; }
        public bool IsSocial { get; set; }
        public int FromResidentBenefits { get; set; }
        public int ToResidentBenefits { get; set; }
        public long? ServiceTypeId { get; set; }
        public int IsLonePensioner { get; set; }

        public virtual FasetItem ApartmentType { get; set; }
        public virtual Service1 Service { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
