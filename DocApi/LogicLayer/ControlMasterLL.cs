using DocApi.DataLayer;
using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.LogicLayer
{
    internal sealed class ControlMasterLL
    {
        private ControlMasterDL _dac = new ControlMasterDL();
        internal List<CONTROL_MASTER> GetAllControlMaster()
        {
            return _dac.GetAllControlMaster();
        }

        
    }
}