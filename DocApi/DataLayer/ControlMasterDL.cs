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
    }
}