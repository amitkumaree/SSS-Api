using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public class SUB_QUESTION_CATEGORY_AND_CHILD
    {
        public SUB_QUESTION_CATEGORY SUB_QUESTION_CATEGORY { get; set; }

        public List<QUESTION_ITEM_AND_CHILD> QUESTION_ITEM_AND_CHILDs { get; set; }

        public SUB_QUESTION_CATEGORY_AND_CHILD()
        {
            this.QUESTION_ITEM_AND_CHILDs = new List<QUESTION_ITEM_AND_CHILD>();
        }


    }
}