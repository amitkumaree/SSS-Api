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
            _logicLayer.InsertQuestionCategory(qc);
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
