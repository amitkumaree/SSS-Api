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

        internal List<SUB_DOMAIN> GetSubDomain(int id)
        {
            var subDomains = new List<SUB_DOMAIN>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetSubDomainByDomId, id);
                using (var command = MySqlDbConnection.Command(connection, _statement))
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

        internal void InsertSubDomain(SUB_DOMAIN sdm)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertSubDomain,
                                          sdm.DOM_ID.Value ,
                                          string.Concat("'", sdm.NAME, "'"),
                                          string.Concat("'", sdm.DESCRIPTION, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(sdm.DEL_FLG) ? "N" : sdm.DEL_FLG, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(sdm.ORGL_USER) ? "ADMIN" : sdm.ORGL_USER, "'"),
                                          "SYSDATE()"
                                          );
                
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void UpdateSubDomain(SUB_DOMAIN sdm)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.UpdateSubDomain,
                                          sdm.DOM_ID.HasValue ?  Convert.ToString(sdm.DOM_ID.Value) : "DOM_ID",
                                          string.IsNullOrWhiteSpace(sdm.NAME) ? "NAME" : string.Concat("'", sdm.NAME, "'"),
                                          string.IsNullOrWhiteSpace(sdm.DESCRIPTION) ? "DESCRIPTION" : string.Concat("'", sdm.DESCRIPTION, "'"),
                                          string.IsNullOrWhiteSpace(sdm.UPDT_USER) ? "UPDT_USER" : string.Concat("'", sdm.UPDT_USER, "'"),
                                          "SYSDATE()",
                                          sdm.SUB_DOM_ID.Value
                                          );


                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }


        internal void DeleteSubDomain(int subDom)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.DeleteSubDomain,
                                          subDom
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }


    }
}