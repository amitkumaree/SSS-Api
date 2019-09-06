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
        public List<QUESTION_CONTROL> Get()
        {
            return _logicLayer.GetAllQuestionControl();
        }

        // GET: api/Domain/5
        public QUESTION_CONTROL Get(int id)
        {
            return null;
        }

        // POST: api/Domain
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Domain/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
        }
    }
}
