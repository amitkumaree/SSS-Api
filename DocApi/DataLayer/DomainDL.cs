﻿using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class DomainDL
    {
        string _statement;
        internal List<DOMAIN> GetAllDomains()
        {
            var domains = new List<DOMAIN>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetAllDomain);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var domain = new DOMAIN();

                                domain.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);
                                domain.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                domain.DESCRIPTION = UtilityDL.CheckNull<string>(reader["DESCRIPTION"]);
                                domain.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);
                                domain.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);
                                domain.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);
                                domain.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);
                                domain.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);

                                domains.Add(domain);
                            }
                        }
                    }
                }
            }

            return domains;
        }

        internal DOMAIN GetDomain(int id)
        {
            var domain = new DOMAIN();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetDomain, id);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                domain.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);
                                domain.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                domain.DESCRIPTION = UtilityDL.CheckNull<string>(reader["DESCRIPTION"]);
                                domain.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);
                                domain.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);
                                domain.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);
                                domain.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);
                                domain.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);
                            }
                        }
                    }
                }
            }

            return domain;
        }


        internal void InsertDomain(DOMAIN dm)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertDomain,
                                          dm.DOM_ID,
                                          string.Concat("'", dm.NAME, "'"),
                                          string.Concat("'", dm.DESCRIPTION, "'"),
                                          string.Concat("'", dm.DEL_FLG, "'"),
                                          string.Concat("'", dm.ORGL_USER, "'"),
                                          string.Concat("'", "SYSDATE()", "'")
                                          );
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }
    }
}