using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public sealed class CONTROL_MASTER
    {
        public string CONTROL_TYP { get; set; }
        public string NAME { get; set; }
        public string LABEL { get; set; }
        public string SAMPLE_PIC { get; set; }
        public string DEL_FLG { get; set; }
        public string ORGL_USER { get; set; }
        public string UPDT_USER { get; set; }
        public int? CM_ID { get; set; }
        public DateTime? ORGL_STAMP { get; set; }
        public DateTime? UPDT_STAMP { get; set; }

    }
}