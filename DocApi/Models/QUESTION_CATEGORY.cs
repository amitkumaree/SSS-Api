using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public sealed class QUESTION_CATEGORY
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int? QC_ID { get; set; }
        public int? DOM_ID { get; set; }
        public int? SUB_DOM_ID { get; set; }
    }
}