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
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    //[EnableCors()]
    public class DomainController : ApiController
    {
        DomainLL _logicLayer = new DomainLL();
        // GET: api/Domain
        /// <summary>
        /// It returns all the DOMAIN values as List
        /// </summary>
        /// <returns></returns>
        public List<DOMAIN> Get()
        {
            return _logicLayer.GetAllDomain();
        }

        // GET: api/Domain/5
        /// <summary>
        /// Not used
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DOMAIN Get(int id)
        {
            return _logicLayer.GetDomain(id);
        }

        // POST: api/Domain
        //[HttpPost]
        /// <summary>
        /// It takes the parameter of DOMAIN model type.
        /// If DOMAIN.DOM_ID = 0 then it performs INSERT
        /// If DOMAIN.DOM_ID > 0 and DOMAIN.DEL_FLG = N then it performs UPDATE.
        /// If DOMAIN.DEL_FLG = Y then it performs DELETE.
        /// </summary>
        /// <param name="dm"></param>
        public void Post([FromBody] DOMAIN dm) //For Insert
        {
            if ((dm.DOM_ID.HasValue ? dm.DOM_ID.Value : 0) == 0)
            {
                _logicLayer.InsertDomain(dm);
            }
            else
                if (dm.DOM_ID.Value > 0 && (string.IsNullOrWhiteSpace(dm.DEL_FLG) ? "N" : dm.DEL_FLG) == "N")
            {
                _logicLayer.UpdateDomain(dm);
            }
            else
                _logicLayer.DeleteDomain(dm.DOM_ID.Value);

        }

        // PUT: api/Domain/5
        public void Put([FromBody] DOMAIN dm) //, [FromBody]string value) //For Update
        {
            _logicLayer.UpdateDomain(dm);
        }

        // DELETE: api/Domain/5
        public void Delete(int id)
        {
            _logicLayer.DeleteDomain(id);
        }
    }
}
