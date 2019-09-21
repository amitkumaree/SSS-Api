using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public class QUESTION_ITEM_AND_CHILD
    {
        public QUESTION_ITEM QUESTION_ITEM { get; set; }
        public List<QUESTION_CONTROL> QUESTION_CONTROLs { get; set; }

        public QUESTION_ITEM_AND_CHILD()
        {
            this.QUESTION_CONTROLs = new List<QUESTION_CONTROL>();
        }


    }
}