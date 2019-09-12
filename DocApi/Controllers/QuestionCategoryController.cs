using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class QuestionCategoryController : ApiController
    {
        QuestionCategoryLL _logicLayer = new QuestionCategoryLL();
        // GET: api/Domain
        public List<QUESTION_CATEGORY> Get(int id)
        {
            return _logicLayer.GetAllQuestionCategory(id);
        }

        // POST: api/Domain
        public void Post([FromBody]QUESTION_CATEGORY qc) //insert 
        {
           if ((qc.QC_ID.HasValue ? qc.QC_ID.Value : 0) == 0)
            {
                _logicLayer.InsertQuestionCategory(qc);
            }
            else
                if (qc.QC_ID.Value > 0 && (string.IsNullOrWhiteSpace(qc.DEL_FLG) ? "N" : qc.DEL_FLG) == "N")
            {
                _logicLayer.UpdateQuestionCategory(qc);
            }
            else
                _logicLayer.DeleteQuestionCategory(qc.QC_ID.Value);
        }

        // PUT: api/Domain/5
        public void Put([FromBody]QUESTION_CATEGORY qc) //update
        {
            _logicLayer.UpdateQuestionCategory(qc);
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            _logicLayer.DeleteQuestionCategory(id);
        }
    }
}
