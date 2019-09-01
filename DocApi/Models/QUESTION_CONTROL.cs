using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public sealed class QUESTION_CONTROL
    {
        public string NAME { get; set; }
        public string LABLE { get; set; }
        public string HINT { get; set; }
        public string OTHDESC { get; set; }
        public string LISTOFVAL { get; set; }
        public int? QCT_ID { get; set; }
        public int? QI_ID { get; set; }
        public int? SQC_ID { get; set; }
        public int? QC_ID { get; set; }
        public int? DOM_ID { get; set; }
        public int? SUB_DOM_ID { get; set; }
        public int? CONTROL_ID { get; set; }
    }
}