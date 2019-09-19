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
        /// <summary>
        /// It takes the parameter DOMIN_ID and returns corresponding SUB_DOMAIN info as List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<SUB_DOMAIN> Get(int id)
        {
            return _logicLayer.GetSubDomain(id);
        }

        // POST: api/SubDomainByDomain
        /// <summary>
        /// Not defined
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SubDomainByDomain/5
        /// <summary>
        /// Not defined
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SubDomainByDomain/5
        /// <summary>
        /// Not defined
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
