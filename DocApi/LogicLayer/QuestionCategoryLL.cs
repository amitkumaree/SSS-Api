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

        internal List<QUESTION_CATEGORY> GetAllQuestionCategory(int subDomId)
        {
            return _dac.GetAllQuestionCategory(subDomId);
        }

        internal QUESTION_CATEGORY_LIST GetQuestionCategory(int subDomId)
        {
            return _dac.GetQuestionCategory(subDomId);
        }


        internal void InsertQuestionCategory(QUESTION_CATEGORY qc)
        {
            _dac.InsertQuestionCategory(qc);
        }


        internal void UpdateQuestionCategory(QUESTION_CATEGORY qc)
        {
            _dac.UpdateQuestionCategory(qc);
        }


        internal void DeleteQuestionCategory(int qcId)
        {
            _dac.DeleteQuestionCategory(qcId);
        }

    }
}