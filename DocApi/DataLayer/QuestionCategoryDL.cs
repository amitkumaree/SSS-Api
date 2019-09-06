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
                                questCat.SEQ_NO = UtilityDL.CheckNull<int>(reader["SEQ_NO"]);

                                questCat.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);
                                questCat.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);
                                questCat.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);
                                questCat.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);
                                questCat.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);

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