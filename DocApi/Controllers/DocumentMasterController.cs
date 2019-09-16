using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class DocumentMasterController : ApiController
    {
        DocumentMasterLL _logicLayer = new DocumentMasterLL();
        // GET: api/Domain
        public List<DOCUMENT_MASTER> Get(int id)
        {
            return _logicLayer.GetDocumentMaster(id);
        }

        // POST: api/Domain
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
