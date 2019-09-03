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
        public List<QUESTION_CATEGORY> Get()
        {
            return _logicLayer.GetAllQuestionCategory();
        }

        // GET: api/Domain/5
        public QUESTION_CATEGORY Get(int id)
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
