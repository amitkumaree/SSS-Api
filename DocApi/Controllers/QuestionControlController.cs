using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class QuestionControlController : ApiController
    {
        QuestionControlLL _logicLayer = new QuestionControlLL();
        // GET: api/Domain
        public List<QUESTION_CONTROL> Get(int id)
        {
            return _logicLayer.GetAllQuestionControl(id);
        }

        
        // POST: api/Domain
        public void Post([FromBody]QUESTION_CONTROL qc)
        {
            _logicLayer.InsertQuestionControl(qc);
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
