using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public sealed class DOCUMENT_MASTER : ParentModel
    {
        public int? DM_ID { get; set; }
        public int? SUB_DOM_ID { get; set; }
        public string CONTENT { get; set; }
        public string DEL_FLG { get; set; }
        public string ORGL_USER { get; set; }
        public string UPDT_USER { get; set; }
        public DateTime? ORGL_STAMP { get; set; }
        public DateTime? UPDT_STAMP { get; set; }


    }

}