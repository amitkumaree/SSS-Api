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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Domain/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
        }
    }
}
