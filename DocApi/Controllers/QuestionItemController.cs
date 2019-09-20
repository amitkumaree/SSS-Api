using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class QuestionItemController : ApiController
    {
        QuestionItemLL _logicLayer = new QuestionItemLL();
        // GET: api/QuestionItem
        /// <summary>
        ///  It takes the SUB_QUESTION_CATEGORY_ID as parameter and returns corresponding QUESTION_ITEM info as List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<QUESTION_ITEM> Get(int? id)
        {
            int val;

            if (id.HasValue)
                val = id.Value;
            else
                val = 0;

            return _logicLayer.GetAllQuestionItem(val);
        }

        // POST: api/QuestionItem
        /// <summary>
        /// It takes the parameter QUESTION_ITEM model type.
        /// If QUESTION_ITEM.QI_ID = 0 or NULL then it performs INSERT.
        /// If QUESTION_ITEM.QI_ID > 0 and QUESTION_ITEM.DEL_FLG=N then it performs UPDATE.
        /// If QUESTION_ITEM.DEL_FLG=Y then it performs DELETE.
        /// </summary>
        /// <param name="qi"></param>
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
