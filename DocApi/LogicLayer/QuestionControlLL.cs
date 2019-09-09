using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    internal sealed class QuestionControlLL
    {
        private QuestionControlDL _dac = new QuestionControlDL();

        internal List<QUESTION_CONTROL> GetAllQuestionControl(int qiId)
        {
            return _dac.GetAllQuestionControl(qiId);
        }


        internal void InsertQuestionControl(QUESTION_CONTROL qc)
        {
            _dac.InsertQuestionControl(qc);
        }


        internal void UpdateQuestionControl(QUESTION_CONTROL qc)
        {
            _dac.UpdateQuestionControl(qc);
        }


        internal void DeleteQuestionControl(int qcId)
        {
            _dac.DeleteQuestionControl(qcId);
        }

    }
}