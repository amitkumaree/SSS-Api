using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    internal sealed class QuestionControlAndControlMasterLL
    {
        private QuestionControlAndControlMasterDL _dac = new QuestionControlAndControlMasterDL();

        internal List<QUESTION_CONTROL_AND_CONTROL_MASTER> GetQuestionControlAndControlMaster(int qiId)
        {
            return _dac.GetQuestionControlAndMaster(qiId);
        }


        internal void InsertQuestionControl(QUESTION_CONTROL qc)
        {
           
        }


        internal void UpdateQuestionControl(QUESTION_CONTROL qc)
        {
           
        }


        internal void DeleteQuestionControl(int qcId)
        {
           
        }

    }
}