using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public class QUESTION_CATEGORY_AND_CHILD
    {
        public QUESTION_CATEGORY QUESTION_CATEGORY { get; set; }
        public List<SUB_QUESTION_CATEGORY_AND_CHILD> SUB_QUESTION_CATEGORY_AND_CHILDs { get; set; }

        public QUESTION_CATEGORY_AND_CHILD()
            {
             this.SUB_QUESTION_CATEGORY_AND_CHILDs = new List<SUB_QUESTION_CATEGORY_AND_CHILD>();
            }
    }
}