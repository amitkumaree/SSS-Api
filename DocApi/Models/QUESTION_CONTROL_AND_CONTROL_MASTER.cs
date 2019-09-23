using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public sealed class QUESTION_CONTROL_AND_CONTROL_MASTER
    {
        public string NAME { get; set; }
        public string LABEL { get; set; }
        public string HINT { get; set; }
        public string OTHDESC { get; set; }
        public string LISTOFVAL { get; set; }
        public int? SEQ_NO { get; set; }
        public int? QCT_ID { get; set; }
        public int? QI_ID { get; set; }
        public int? SQC_ID { get; set; }
        public int? QC_ID { get; set; }
        public int? DOM_ID { get; set; }
        public int? SUB_DOM_ID { get; set; }
        public int? CONTROL_ID { get; set; }
        public string ORGL_USER { get; set; }
        public DateTime? ORGL_STAMP { get; set; }
        public string UPDT_USER { get; set; }
        public DateTime? UPDT_STAMP { get; set; }
        public string DEL_FLG { get; set; }

        public string CONTROL_TYP { get; set; }
        public string CONTROL_NAME { get; set; }
        public string CONTROL_LABEL { get; set; }
        public string SAMPLE_PIC { get; set; }

    }
}