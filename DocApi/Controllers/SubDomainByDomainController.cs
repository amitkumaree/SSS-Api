using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DocApi.LogicLayer;
using DocApi.Models;

namespace DocApi.Controllers
{
    public class SubDomainByDomainIdController : ApiController
    {
        SubDomainLL _logicLayer = new SubDomainLL();

        // GET: api/SubDomainByDomain/5
        public List<SUB_DOMAIN> Get(int id)
        {
            return _logicLayer.GetSubDomain(id);
        }

        // POST: api/SubDomainByDomain
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SubDomainByDomain/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SubDomainByDomain/5
        public void Delete(int id)
        {
        }
    }
}
