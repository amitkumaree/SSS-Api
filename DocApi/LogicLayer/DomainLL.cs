﻿using DocApi.DataLayer;
using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.LogicLayer
{
    internal sealed class DomainLL
    {
        private DomainDL _dac = new DomainDL();
        internal List<DOMAIN> GetAllDomain()
        {
            return _dac.GetAllDomains();
        }

        internal DOMAIN GetDomain(int id)
        {
            return _dac.GetDomain(id);
        }
    }
}