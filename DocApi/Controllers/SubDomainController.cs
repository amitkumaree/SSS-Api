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
            return _logicLayer.GetSubDomain(id);
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
