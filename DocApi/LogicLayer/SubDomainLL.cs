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

        internal List<SUB_DOMAIN> GetSubDomain(int id)
        {
            return _dac.GetSubDomain(id);
        }

        internal void InsertSubDomain(SUB_DOMAIN sd)
        {
            _dac.InsertSubDomain(sd);
        }


        internal void UpdateSubDomain(SUB_DOMAIN sd)
        {
            _dac.UpdateSubDomain(sd);
        }


        internal void DeleteSubDomain(int qiId)
        {
            _dac.DeleteSubDomain(qiId);
        }

    }
}