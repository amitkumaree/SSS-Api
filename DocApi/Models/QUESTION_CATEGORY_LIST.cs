using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.Models
{
    public class QUESTION_CATEGORY_LIST
    {
        public List<QUESTION_CATEGORY> QuestionCategory { get; set; }

        public QUESTION_CATEGORY_LIST()
        {
            this.QuestionCategory = new List<QUESTION_CATEGORY>();
        }
    }
}