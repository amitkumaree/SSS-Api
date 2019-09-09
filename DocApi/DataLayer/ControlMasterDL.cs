using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class ControlMasterDL
    {
        string _statement;
        internal List<CONTROL_MASTER> GetAllControlMaster()
        {
            var ControlMaster = new List<CONTROL_MASTER>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetControlMaster);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var controlMas = new CONTROL_MASTER();

                                controlMas.CM_ID = UtilityDL.CheckNull<int>(reader["CM_ID"]);
                                controlMas.CONTROL_TYP = UtilityDL.CheckNull<string>(reader["CONTROL_TYP"]);
                                controlMas.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                controlMas.LABEL = UtilityDL.CheckNull<string>(reader["LABEL"]);
                                controlMas.SAMPLE_PIC = UtilityDL.CheckNull<string>(reader["SAMPLE_PIC"]);
                                controlMas.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);
                                controlMas.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);
                                controlMas.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);
                                controlMas.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);
                                controlMas.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);

                                ControlMaster.Add(controlMas);
                            }
                        }
                    }
                }

                return ControlMaster;
            }

        }

        internal void InsertControlMaster(CONTROL_MASTER cm)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertControlMaster,
                                           string.Concat("'", cm.CONTROL_TYP, "'"),
                                          string.Concat("'", cm.NAME, "'"),
                                          string.Concat("'", cm.LABEL, "'"),
                                          string.Concat("'", cm.SAMPLE_PIC, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(cm.DEL_FLG) ? "N" : cm.DEL_FLG, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(cm.ORGL_USER) ? "ADMIN" : cm.ORGL_USER, "'"),
                                          "SYSDATE()"
                                          );
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }
            }
        }

        internal void UpdateControlMaster(CONTROL_MASTER cm)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.UpdateControlMaster,
                                          string.IsNullOrWhiteSpace(cm.CONTROL_TYP) ? "CONTROL_TYP" : string.Concat("'", cm.CONTROL_TYP, "'"),
                                          string.IsNullOrWhiteSpace(cm.NAME) ? "NAME" : string.Concat("'", cm.NAME, "'"),
                                          string.IsNullOrWhiteSpace(cm.LABEL) ? "LABEL" : string.Concat("'", cm.LABEL, "'"),
                                          string.IsNullOrWhiteSpace(cm.SAMPLE_PIC) ? "SAMPLE_PIC" : string.Concat("'", cm.SAMPLE_PIC, "'"),
                                          string.IsNullOrWhiteSpace(cm.UPDT_USER) ? "UPDT_USER" : string.Concat("'", cm.UPDT_USER, "'"),
                                          "SYSDATE()",
                                          cm.CM_ID.Value
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void DeleteControlMaster(int cmId)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.DeleteControlMaster,
                                          cmId
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }


    }
}