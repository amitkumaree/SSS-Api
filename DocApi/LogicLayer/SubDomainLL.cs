using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    internal sealed class SubDomainLL
    {
        private SubDomainDL _dac = new SubDomainDL();
        internal List<SUB_DOMAIN> GetAllSubDomain()
        {
            return _dac.GetAllSubDomains();
        }

        internal SUB_DOMAIN GetSubDomain(int id)
        {
            return _dac.GetSubDomain(id);
        }
    }
}