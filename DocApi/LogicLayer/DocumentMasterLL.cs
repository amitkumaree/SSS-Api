using DocApi.DataLayer;
using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.LogicLayer
{
    internal sealed class DocumentMasterLL
    {
        private DocumentMasterDL _dac = new DocumentMasterDL();
       
        internal List<DOCUMENT_MASTER> GetDocumentMaster(int id)
        {
            return _dac.GetDocumentMaster(id);
        }

        internal void InsertDocumentMaster(DOCUMENT_MASTER dm)
        {
            _dac.InsertDocumentMaster(dm);
        }


        internal void UpdateDocumentMaster(DOCUMENT_MASTER dm)
        {
            _dac.UpdateDocumentMaster(dm);
        }


        internal void DeleteDocumentMaster(int id)
        {
            _dac.DeleteDocumentMaster(id);
        }


    }
}