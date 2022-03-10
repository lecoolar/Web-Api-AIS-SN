﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestsView
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public long? MapId { get; set; }
        public long? StepId { get; set; }
        public long? AccountId { get; set; }
        public string Comment { get; set; }
        public long? GroupOperId { get; set; }
        public byte? RequestTypeId { get; set; }
        public long? AddrId { get; set; }
        public string AddrName { get; set; }
        public string StatusName { get; set; }
        public string RequestTypesName { get; set; }
        public string RequestTypeCode { get; set; }
        public int? StatusId { get; set; }
        public string TypeFormCode { get; set; }
        public long? ExternalProcessingTemplateId { get; set; }
        public bool? IsPreview { get; set; }
        public string CompletedWork { get; set; }
        public DateTime Processed { get; set; }
        public bool? IsShowProgress { get; set; }
        public string FasetItemStatusName { get; set; }
        public byte? Status { get; set; }
        public string XmlIn { get; set; }
    }
}
