using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class SubQuestionCategoryController : ApiController
    {
        SubQuestionCategoryLL _logicLayer = new SubQuestionCategoryLL();
        // GET: api/SubQuestionCategory
        /// <summary>
        /// It takes one parameter QUESTION_CATEGORY_ID and returns SUB_QUESTION_CATEGORY info as List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<SUB_QUESTION_CATEGORY> Get(int id)
        {
            return _logicLayer.GetAllSubQuestionCategory(id);
        }

        // POST: api/SubQuestionCategory
        /// <summary>
        /// It takes the parameter SUB_QUESTION_CATEGORY model type .
        /// If SUB_QUESTION_CATEGORY.SQC_ID = 0 or NULL then it performs INSERT
        /// If SUB_QUESTION_CATEGORY.SQC_ID > 0 and SUB_QUESTION_CATEGORY.DEL_FLG=N then it performs UPDATE
        /// If SUB_QUESTION_CATEGORY.DEL_FLG=Y then it performs DELETE
        /// </summary>
        /// <param name="sqc"></param>
        public void Post([FromBody]SUB_QUESTION_CATEGORY sqc)
        {
            if ((sqc.SQC_ID.HasValue ? sqc.SQC_ID.Value : 0) == 0)
            {
                _logicLayer.InsertSubQuestionCategory(sqc);
            }
            else
                if (sqc.SQC_ID.Value > 0 && (string.IsNullOrWhiteSpace(sqc.DEL_FLG) ? "N" : sqc.DEL_FLG) == "N")
            {
                _logicLayer.UpdateSubQuestionCategory(sqc);
            }
            else
                _logicLayer.DeleteSubQuestionCategory(sqc.SQC_ID.Value);

        }

        // PUT: api/Domain/5
        public void Put([FromBody]SUB_QUESTION_CATEGORY sc)
        {
            _logicLayer.UpdateSubQuestionCategory(sc);
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            _logicLayer.DeleteSubQuestionCategory(id);
        }
    }
}
