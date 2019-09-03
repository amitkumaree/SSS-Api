using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    internal sealed class QuestionItemLL
    {
        private QuestionItemDL _dac = new QuestionItemDL();

        internal List<QUESTION_ITEM> GetAllQuestionItem()
        {
            return _dac.GetAllQuestionItem();
        }
    }
}