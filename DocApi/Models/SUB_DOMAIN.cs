﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public sealed class SUB_DOMAIN
    {
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int? SUB_DOM_ID { get; set; }
        public int? DOM_ID { get; set; }
        public string ORGL_USER { get; set; }
        public DateTime? ORGL_STAMP { get; set; }
        public string UPDT_USER { get; set; }
        public DateTime? UPDT_STAMP { get; set; }
        public string DEL_FLG { get; set; }
    }
}