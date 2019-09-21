using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace DocApi.Controllers
{
    public class QuestionCategoryAndChildsController : ApiController
    {
        QuestionCategoryAndChildsLL _logiclayer = new QuestionCategoryAndChildsLL();
        //get: api/questioncategoryandchilds/5
        public List<QUESTION_CATEGORY_AND_CHILD> get(int id)
        {
            return _logiclayer.QuestionCategoryAndChilds(id);
        }

        //post: api/questioncategoryandchilds
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/questioncategoryandchilds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/questioncategoryandchilds/5
        public void Delete(int id)
        {
        }
    }
}
