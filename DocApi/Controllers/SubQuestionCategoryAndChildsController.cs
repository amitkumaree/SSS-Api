using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace DocApi.Controllers
{
    public class SubQuestionCategoryAndChildsController : ApiController
    {
        SubQuestionCategoryAndChildsControllerLL _logiclayer = new SubQuestionCategoryAndChildsControllerLL();
        //get: api/subquestioncategoryandchilds/5
        public List<SUB_QUESTION_CATEGORY_AND_CHILD> get(int id)
        {
           return _logiclayer.SubQuestionCategoryAndChilds(id);
        }

        //post: api/subquestioncategoryandchilds
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SubQuestionCategoryAndChilds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SubQuestionCategoryAndChilds/5
        public void Delete(int id)
        {
        }
    }
}
