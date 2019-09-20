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
        internal List<SUB_QUESTION_CATEGORY> GetSubQuestionCategory(int qcId)
        {
            var SubQuestionCategory = new List<SUB_QUESTION_CATEGORY>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetSubQuestionCat,
                                           qcId > 0 ? Convert.ToString(qcId) : "QC_ID");
                //qcId);
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


        internal void InsertSubQuestionCategory(SUB_QUESTION_CATEGORY sqc)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertSubQuestionCategory,
                                          sqc.QC_ID.Value ,
                                          sqc.DOM_ID.Value ,
                                          sqc.SUB_DOM_ID.Value ,
                                          string.Concat("'", sqc.NAME, "'"),
                                          string.Concat("'", sqc.DESCRIPTION, "'"),
                                          sqc.SEQ_NO.Value,
                                          string.Concat("'", string.IsNullOrWhiteSpace(sqc.DEL_FLG) ? "N" : sqc.DEL_FLG, "'"), //dm.DEL_FLG
                                          string.Concat("'", string.IsNullOrWhiteSpace(sqc.ORGL_USER) ? "ADMIN" : sqc.ORGL_USER, "'"),
                                          "SYSDATE()"
                                          );



                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void UpdateSubQuestionCategory(SUB_QUESTION_CATEGORY sqc)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.UpdateSubQuestionCategory ,
                                          sqc.QC_ID.HasValue ?  Convert.ToString(sqc.QC_ID.Value) : "QC_ID" ,
                                          sqc.DOM_ID.HasValue ?  Convert.ToString(sqc.DOM_ID.Value) : "DOM_ID" ,
                                          sqc.SUB_DOM_ID.HasValue ? Convert.ToString(sqc.SUB_DOM_ID.Value) : "SUB_DOM_ID" ,
                                          string.IsNullOrWhiteSpace(sqc.NAME) ? "NAME" : string.Concat("'", sqc.NAME, "'"),
                                          string.IsNullOrWhiteSpace(sqc.DESCRIPTION) ? "DESCRIPTION" : string.Concat("'", sqc.DESCRIPTION, "'"),
                                          sqc.SEQ_NO.HasValue ? Convert.ToString(sqc.SEQ_NO.Value) : "SEQ_NO",
                                          string.IsNullOrWhiteSpace(sqc.UPDT_USER) ? "UPDT_USER" : string.Concat("'", sqc.UPDT_USER, "'"),
                                          "SYSDATE()",
                                          sqc.SQC_ID.Value
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }


        internal void DeleteSubQuestionCategory(int subQustCat)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.DeleteSubQuestionCategory,
                                          subQustCat
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

    }
}