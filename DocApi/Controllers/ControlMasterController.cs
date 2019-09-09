using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class ControlMasterController : ApiController
    {
        ControlMasterLL _logicLayer = new ControlMasterLL();
        // GET: api/Domain
        public List<CONTROL_MASTER> Get()
        {
            return _logicLayer.GetAllControlMaster();
        }

        // GET: api/Domain/5
        public CONTROL_MASTER Get(int id)
        {
            return null;
        }

        // POST: api/Domain
        public void Post([FromBody]CONTROL_MASTER cm)
        {
            _logicLayer.InsertControlMaster(cm);
        }

        // PUT: api/Domain/5
        public void Put([FromBody]CONTROL_MASTER cm)
        {
            _logicLayer.UpdateControlMaster(cm);
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            _logicLayer.DeleteControlMaster(id);
        }
    }
}
