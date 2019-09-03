using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class QuestionCategoryDL
    {
        string _statement;
        internal List<QUESTION_CATEGORY> GetAllQuestionCategory()
        {
            var questionCategory = new List<QUESTION_CATEGORY>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionCat);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var questCat = new QUESTION_CATEGORY();

                                questCat.QC_ID = UtilityDL.CheckNull<int>(reader["QC_ID"]);
                                questCat.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);
                                questCat.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);
                                questCat.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                questCat.DESCRIPTION = UtilityDL.CheckNull<string>(reader["DESCRIPTION"]);

                                questionCategory.Add(questCat);
                            }
                        }
                    }
                }
            }

            return questionCategory;
        }

    }
}