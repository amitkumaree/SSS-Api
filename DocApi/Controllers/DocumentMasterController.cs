using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class DocumentMasterController : ApiController
    {
        DocumentMasterLL _logicLayer = new DocumentMasterLL();
        // GET: api/DocumentMaster
        /// <summary>
        /// Takes the parameter SUB_DOM_ID and returns the corresponding List of DOCUMENT_MASTER records
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<DOCUMENT_MASTER> Get(int id)
        {
            return _logicLayer.GetDocumentMaster(id);
        }

        // POST: api/DocumentMaster
        /// <summary>
        /// It takes the parameter of DOCUMENT_MASTER model type.
        /// if DOCUMENT_MASTER.DM_ID = 0 or NULL then it performs INSERT.
        /// if DOCUMENT_MASTER.DM_ID > 0 and DOCUMENT_MASTER.DEL_FLG=N then it performs UPDATE.
        /// if DOCUMENT_MASTER.DEL_FLG=Y then it performs DELETE.
        /// </summary>
        /// <param name="dm"></param>
        public void Post([FromBody] DOCUMENT_MASTER dm)
        {
            if ((dm.DM_ID.HasValue ? dm.DM_ID.Value : 0) == 0)
            {
                _logicLayer.InsertDocumentMaster(dm);
            }
            else
                if (dm.DM_ID.Value > 0 && (string.IsNullOrWhiteSpace(dm.DEL_FLG) ? "N" : dm.DEL_FLG) == "N")
            {
                _logicLayer.UpdateDocumentMaster(dm);
            }
            else
                _logicLayer.DeleteDocumentMaster(dm.DM_ID.Value);

        }
    }
}
