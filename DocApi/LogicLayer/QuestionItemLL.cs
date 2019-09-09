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

        internal List<QUESTION_ITEM> GetAllQuestionItem(int sqcId)
        {
            return _dac.GetAllQuestionItem(sqcId);
        }

        internal void InsertQuestionItem(QUESTION_ITEM qi)
        {
            _dac.InsertQuestionItem(qi);
        }


        internal void UpdateQuestionItem(QUESTION_ITEM qi)
        {
            _dac.UpdateQuestionItem(qi);
        }


        internal void DeleteQuestionItem(int qiId)
        {
            _dac.DeleteQuestionItem(qiId);
        }

    }
}