﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public class QUESTION_ITEM_AND_CHILD
    {
        public QUESTION_ITEM QUESTION_ITEM { get; set; }
        public List<QUESTION_CONTROL_AND_CONTROL_MASTER> QUESTION_CONTROL_AND_CONTROL_MASTERs { get; set; }

        public QUESTION_ITEM_AND_CHILD()
        {
            this.QUESTION_CONTROL_AND_CONTROL_MASTERs = new List<QUESTION_CONTROL_AND_CONTROL_MASTER>();
        }


    }
}