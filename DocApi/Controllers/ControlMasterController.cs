using DocApi.LogicLayer;
using DocApi.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace DocApi.Controllers
{
    public class ControlMasterController : ApiController
    {
        ControlMasterLL _logicLayer = new ControlMasterLL();
        // GET: api/ControlMaster
        /// <summary>
        /// This method returns all the List of CONTROL_MASTER Info
        /// </summary>
        /// <returns></returns>
        public List<CONTROL_MASTER> Get()
        {
            return _logicLayer.GetAllControlMaster();
        }

        // GET: api/Domain/5
        /// <summary>
        /// This method is not declared
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CONTROL_MASTER Get(int id)
        {
            return null;
        }

        // POST: api/ControlMaster
        /// <summary>
        /// Take the parameter of CONTROL_MASTER model type
        /// if CONTROL_MASTER.CM_ID = 0 or Null then it performs INSERT
        /// if CONTROL_MASTER.CM_ID > 0 and CONTROL_MASTER.DEL_FLG=N then it performs UPDATE
        /// if CONTROL_MASTER.DEL_FLG=Y then it performs DELETE
        /// </summary>
        /// <param name="cm"></param>
        public void Post([FromBody]CONTROL_MASTER cm)
        {
           if ((cm.CM_ID.HasValue ? cm.CM_ID.Value : 0) == 0)
            {
                _logicLayer.InsertControlMaster(cm);
            }
            else
                if (cm.CM_ID.Value > 0 && (string.IsNullOrWhiteSpace(cm.DEL_FLG) ? "N" : cm.DEL_FLG) == "N")
            {
                _logicLayer.UpdateControlMaster(cm);
            }
            else
                _logicLayer.DeleteControlMaster(cm.CM_ID.Value);

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
