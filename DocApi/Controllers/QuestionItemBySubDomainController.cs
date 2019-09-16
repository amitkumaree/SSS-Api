using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class QuestionItemBySubDomainController : ApiController
    {
        QuestionItemBySubDomainLL _logicLayer = new QuestionItemBySubDomainLL();
        // GET: api/Domain
        public List<QUESTION_ITEM> Get(int id)
        {
            return _logicLayer.GetAllQuestionItem(id);
        }

        // POST: api/Domain
        public void Post([FromBody] QUESTION_ITEM qi)
        {
             

        }

        // PUT: api/Domain/5
        public void Put([FromBody]QUESTION_ITEM qi)
        {
            
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            
        }
    }
}
