using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    internal sealed class QuestionCategoryLL
    {
        private QuestionCategoryDL _dac = new QuestionCategoryDL();

        internal List<QUESTION_CATEGORY> GetAllQuestionCategory()
        {
            return _dac.GetAllQuestionCategory();
        }
    }
}