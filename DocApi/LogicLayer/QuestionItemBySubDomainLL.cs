using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    internal sealed class QuestionItemBySubDomainLL
    {
        private QuestionItemBySubDomainDL _dac = new QuestionItemBySubDomainDL();

        internal List<QUESTION_ITEM> GetAllQuestionItem(int subDomId)
        {
            return _dac.GetQuestionItem(subDomId);
        }

    }
}