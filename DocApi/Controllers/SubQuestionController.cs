using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class SubQuestionCategoryController : ApiController
    {
        SubQuestionCategoryLL _logicLayer = new SubQuestionCategoryLL();
        // GET: api/Domain
        public List<SUB_QUESTION_CATEGORY> Get()
        {
            return _logicLayer.GetAllSubQuestionCategory();
        }

        // GET: api/Domain/5
        public SUB_QUESTION_CATEGORY Get(int id)
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
