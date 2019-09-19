using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class QuestionItemBySubDomainController : ApiController
    {
        QuestionItemBySubDomainLL _logicLayer = new QuestionItemBySubDomainLL();
        // GET: api/QuestionItemBySubDomain
        /// <summary>
        /// It takes the SUB_DOM_ID as parameter and returns corresponding QUESTION_ITEM info as List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<QUESTION_ITEM> Get(int id)
        {
            return _logicLayer.GetAllQuestionItem(id);
        }

        // POST: api/QuestionItemBySubDomain
        /// <summary>
        /// Not defined
        /// </summary>
        /// <param name="qi"></param>
        public void Post([FromBody] QUESTION_ITEM qi)
        {
             

        }

        // PUT: api/QuestionItemBySubDomain/5
        /// <summary>
        /// Not Defined
        /// </summary>
        /// <param name="qi"></param>
        public void Put([FromBody]QUESTION_ITEM qi)
        {
            
        }

        // DELETE: api/QuestionItemBySubDomain/5
        /// <summary>
        /// Not Defined
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            
        }
    }
}
