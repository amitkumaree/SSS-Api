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
        public List<SUB_QUESTION_CATEGORY> Get(int id)
        {
            return _logicLayer.GetAllSubQuestionCategory(id);
        }

        //// GET: api/Domain/5
        //public SUB_QUESTION_CATEGORY Get(int id)
        //{
        //    return null;
        //}

        // POST: api/Domain
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
