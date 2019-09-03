using DocApi.Models;
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
                            }
                        }
                    }
                }
            }

            return domain;
        }

    }
}