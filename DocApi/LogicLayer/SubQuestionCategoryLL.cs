using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    internal sealed class SubQuestionCategoryLL
    {
        private SubQuestionCategoryDL _dac = new SubQuestionCategoryDL();

        internal List<SUB_QUESTION_CATEGORY> GetAllSubQuestionCategory()
        {
            return _dac.GetAllSubQuestionCategory();
        }
    }
}