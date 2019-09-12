using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class SubDomainController : ApiController
    {
        SubDomainLL _logicLayer = new SubDomainLL();
        // GET: api/SubDomain
        public List<SUB_DOMAIN> Get()
        {
            return _logicLayer.GetAllSubDomain();
        }

        // GET: api/Domain/5
        public SUB_DOMAIN Get(int id)
        {
            //return _logicLayer.GetSubDomain(id);
            return null;
        }

        // POST: api/Domain
        public void Post([FromBody]SUB_DOMAIN sd)
        {           
            if ((sd.SUB_DOM_ID.HasValue ? sd.SUB_DOM_ID.Value : 0) == 0)
            {
                _logicLayer.InsertSubDomain(sd);
            }
            else
                if (sd.SUB_DOM_ID.Value > 0 && (string.IsNullOrWhiteSpace(sd.DEL_FLG) ? "N" : sd.DEL_FLG) == "N")
            {
                _logicLayer.UpdateSubDomain(sd);
            }
            else
                _logicLayer.DeleteSubDomain(sd.SUB_DOM_ID.Value);

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
