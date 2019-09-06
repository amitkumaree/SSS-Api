using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class SubQuestionCategoryDL
    {
        string _statement;
        internal List<SUB_QUESTION_CATEGORY> GetAllSubQuestionCategory()
        {
            var SubQuestionCategory = new List<SUB_QUESTION_CATEGORY>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetSubQuestionCat);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var subQuestCat = new SUB_QUESTION_CATEGORY();

                                subQuestCat.SQC_ID = UtilityDL.CheckNull<int>(reader["SQC_ID"]);
                                subQuestCat.QC_ID = UtilityDL.CheckNull<int>(reader["QC_ID"]);
                                subQuestCat.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);
                                subQuestCat.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);
                                subQuestCat.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);
                                subQuestCat.DESCRIPTION = UtilityDL.CheckNull<string>(reader["DESCRIPTION"]);
                                subQuestCat.SEQ_NO = UtilityDL.CheckNull<int>(reader["SEQ_NO"]);

                                subQuestCat.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);
                                subQuestCat.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);
                                subQuestCat.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);
                                subQuestCat.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);
                                subQuestCat.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);

                                SubQuestionCategory.Add(subQuestCat);
                            }
                        }
                    }
                }

                return SubQuestionCategory;
            }

        }
    }
}