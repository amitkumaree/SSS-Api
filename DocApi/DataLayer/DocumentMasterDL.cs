using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class DocumentMasterDL
    {
        string _statement;
        internal List<DOCUMENT_MASTER> GetDocumentMaster(int id)
        {
            var documentMaster = new List<DOCUMENT_MASTER>();
            var document = new DOCUMENT_MASTER();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetDocumentMaster, id);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                document.DM_ID = UtilityDL.CheckNull<int>(reader["DM_ID"]);
                                document.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);
                                document.CONTENT = UtilityDL.CheckNull<string>(reader["CONTENT"]);

                                documentMaster.Add(document);


                            }
                        }
                    }
                }
            }

            return documentMaster;
        }


        internal void InsertDocumentMaster(DOCUMENT_MASTER dm)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertDocumentMaster,
                                          string.Concat("'", dm.SUB_DOM_ID.Value , "'"),
                                          string.Concat("'", dm.CONTENT, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(dm.DEL_FLG) ? "N" : dm.DEL_FLG, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(dm.ORGL_USER) ? "ADMIN" : dm.ORGL_USER, "'"),
                                           "SYSDATE()"
                                          );
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void UpdateDocumentMaster(DOCUMENT_MASTER dm)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                //var str = MySQLquery.UpdateDomain;
                _statement = string.Format(MySQLquery.UpdateDocumentMaster,
                                           dm.SUB_DOM_ID.HasValue ? Convert.ToString(dm.SUB_DOM_ID.Value) : "SUB_DOM_ID",
                                           string.IsNullOrWhiteSpace(dm.CONTENT) ? "CONTENT" : string.Concat("'", dm.CONTENT, "'"),
                                           string.IsNullOrWhiteSpace(dm.UPDT_USER) ? "UPDT_USER" : string.Concat("'", dm.UPDT_USER, "'"),
                                           "SYSDATE()",
                                           dm.DM_ID.Value
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void DeleteDocumentMaster(int dmId)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.DeleteDocumentMaster,
                                          dmId
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

    }
}