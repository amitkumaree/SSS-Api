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

        internal List<QUESTION_CONTROL> GetAllQuestionControl()
        {
            return _dac.GetAllQuestionControl();
        }
    }
}