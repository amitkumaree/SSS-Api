using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class SubDomainDL
    {
        string _statement;
        internal List<SUB_DOMAIN> GetAllSubDomains()
        {
            var subDomains = new List<SUB_DOMAIN>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetAllSubDomain);
                using (var command = MySqlDbConnection.Command(connection, _statement)) // MySQLquery.GetAllSubDomain))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var subDomain = new SUB_DOMAIN();

                                subDomain.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);
                                subDomain.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);
                                subDomain.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                subDomain.DESCRIPTION = UtilityDL.CheckNull<string>(reader["DESCRIPTION"]);

                                subDomain.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);
                                subDomain.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);
                                subDomain.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);
                                subDomain.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);
                                subDomain.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);

                                subDomains.Add(subDomain);
                            }
                        }
                    }
                }
            }

            return subDomains;
        }

        internal SUB_DOMAIN GetSubDomain(int id)
        {
            var subDomain = new SUB_DOMAIN();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetSubDomainById, id);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                subDomain.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);
                                subDomain.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);
                                subDomain.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                subDomain.DESCRIPTION = UtilityDL.CheckNull<string>(reader["DESCRIPTION"]);
                            }
                        }
                    }
                }
            }

            return subDomain;
        }

    }
}