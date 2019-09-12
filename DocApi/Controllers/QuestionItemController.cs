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
        public List<QUESTION_ITEM> Get(int id)
        {
            return _logicLayer.GetAllQuestionItem(id);
        }

        // POST: api/Domain
        public void Post([FromBody] QUESTION_ITEM qi)
        {
            if ((qi.QI_ID.HasValue ? qi.QI_ID.Value : 0) == 0)
            {
                _logicLayer.InsertQuestionItem(qi);
            }
            else
                if (qi.QI_ID.Value > 0 && (string.IsNullOrWhiteSpace(qi.DEL_FLG) ? "N" : qi.DEL_FLG) == "N")
            {
                _logicLayer.UpdateQuestionItem(qi);
            }
            else
                _logicLayer.DeleteQuestionItem(qi.QI_ID.Value);

        }

        // PUT: api/Domain/5
        public void Put([FromBody]QUESTION_ITEM qi)
        {
            _logicLayer.UpdateQuestionItem(qi);
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            _logicLayer.DeleteQuestionItem(id);
        }
    }
}
