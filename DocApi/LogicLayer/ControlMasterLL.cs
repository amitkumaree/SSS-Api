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

        internal void InsertControlMaster(CONTROL_MASTER cm)
        {
            _dac.InsertControlMaster(cm);
        }


        internal void UpdateControlMaster(CONTROL_MASTER cm)
        {
            _dac.UpdateControlMaster(cm);
        }


        internal void DeleteControlMaster(int cmId)
        {
            _dac.DeleteControlMaster(cmId);
        }

    }
}