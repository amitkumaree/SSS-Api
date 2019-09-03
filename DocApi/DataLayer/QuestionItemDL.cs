using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class QuestionItemDL
    {
        string _statement;
        internal List<QUESTION_ITEM> GetAllQuestionItem()
        {
            var QuestionItem = new List<QUESTION_ITEM>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionItem);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var questItem = new QUESTION_ITEM();

                                questItem.QI_ID = UtilityDL.CheckNull<int>(reader["QI_ID"]);
                                questItem.SQC_ID = UtilityDL.CheckNull<int>(reader["SQC_ID"]);
                                questItem.QC_ID = UtilityDL.CheckNull<int>(reader["QC_ID"]);
                                questItem.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);
                                questItem.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);
                                questItem.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                questItem.DESCRIPTION = UtilityDL.CheckNull<string>(reader["DESCRIPTION"]);

                                QuestionItem.Add(questItem);
                            }
                        }
                    }
                }

                return QuestionItem;
            }

        }
    }
}