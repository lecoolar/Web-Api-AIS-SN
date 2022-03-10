﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ResultNoticesView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountServiceId { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public decimal ToPaySumm { get; set; }
        public decimal ChargeSumm { get; set; }
        public decimal PaymentSumm { get; set; }
        public decimal BeginSaldoSumm { get; set; }
        public string AccountBarcode { get; set; }
        public decimal? AccountToPaySummBarcode { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string TemplateSettingName { get; set; }
        public long? TemplateId { get; set; }
        public string TemplateName { get; set; }
    }
}
