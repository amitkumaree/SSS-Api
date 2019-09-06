using DocApi.LogicLayer;
using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocApi.Controllers
{
    // [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[EnableCors()]
    public class DomainController : ApiController
    {
        DomainLL _logicLayer = new DomainLL();
        // GET: api/Domain
        public List<DOMAIN> Get()
        {
            return _logicLayer.GetAllDomain();
        }

        // GET: api/Domain/5
        public DOMAIN Get(int id)
        {
            return _logicLayer.GetDomain(id);
        }

        // POST: api/Domain
        //[HttpPost]
        public void Post([FromBody] DOMAIN dm)
        {
             _logicLayer.InsertDomain(dm);
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
