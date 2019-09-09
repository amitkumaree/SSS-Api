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

        internal List<SUB_QUESTION_CATEGORY> GetAllSubQuestionCategory(int qcId)
        {
            return _dac.GetAllSubQuestionCategory(qcId);
        }

        internal void InsertSubQuestionCategory(SUB_QUESTION_CATEGORY sqcId)
        {
            _dac.InsertSubQuestionCategory(sqcId);
        }


        internal void UpdateSubQuestionCategory(SUB_QUESTION_CATEGORY sqcId)
        {
            _dac.UpdateSubQuestionCategory(sqcId);
        }


        internal void DeleteSubQuestionCategory(int qiId)
        {
            _dac.DeleteSubQuestionCategory(qiId);
        }


    }
}