using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class QuestionControlController : ApiController
    {
        QuestionControlLL _logicLayer = new QuestionControlLL();
        // GET: api/QuestionControl
        /// <summary>
        /// It takes the parameter QUESTION_ITEM_ID and returns corresponding QUESTION_CONTROL info as List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<QUESTION_CONTROL> Get(int id)
        {
            return _logicLayer.GetAllQuestionControl(id);
        }


        // POST: api/QuestionControl
        /// <summary>
        /// It takes the parameter QUESTION_CONTROL model type.
        /// If QUESTION_CONTROL.QCT_ID = 0 or NULL then it performs INSERT
        /// If QUESTION_CONTROL.QCT_ID > 0 and QUESTION_CONTROL.DEL_FLG=N then it performs UPDATE
        /// If QUESTION_CONTROL.DEL_FLG=Y then it performs DELETE
        /// </summary>
        /// <param name="qct"></param>
        public void Post([FromBody]QUESTION_CONTROL qct)
        {
           if ((qct.QCT_ID.HasValue ? qct.QCT_ID.Value : 0) == 0)
            {
                _logicLayer.InsertQuestionControl(qct);
            }
            else
                if (qct.QCT_ID.Value > 0 && (string.IsNullOrWhiteSpace(qct.DEL_FLG) ? "N" : qct.DEL_FLG) == "N")
            {
                _logicLayer.UpdateQuestionControl(qct);
            }
            else
                _logicLayer.DeleteQuestionControl(qct.QCT_ID.Value);

        }

        // PUT: api/Domain/5
        public void Put([FromBody]QUESTION_CONTROL qc)
        {
            _logicLayer.UpdateQuestionControl(qc);
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            _logicLayer.DeleteQuestionControl(id);
        }
    }
}
