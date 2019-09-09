using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class SubDomainController : ApiController
    {
        SubDomainLL _logicLayer = new SubDomainLL();
        // GET: api/Domain
        public List<SUB_DOMAIN> Get()
        {
            return _logicLayer.GetAllSubDomain();
        }

        // GET: api/Domain/5
        public SUB_DOMAIN Get(int id)
        {
            // return _logicLayer.GetSubDomain(id);
            return null;
        }

        // POST: api/Domain
        public void Post([FromBody]SUB_DOMAIN sd)
        {
            _logicLayer.InsertSubDomain(sd);
        }

        // PUT: api/Domain/5
        public void Put([FromBody]SUB_DOMAIN sd)
        {
            _logicLayer.UpdateSubDomain(sd);
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            _logicLayer.DeleteSubDomain(id);
        }
    }
}
