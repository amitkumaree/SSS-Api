using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class QuestionItemController : ApiController
    {
        QuestionItemLL _logicLayer = new QuestionItemLL();
        // GET: api/Domain
        public List<QUESTION_ITEM> Get()
        {
            return _logicLayer.GetAllQuestionItem();
        }

        // GET: api/Domain/5
        public QUESTION_ITEM Get(int id)
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
