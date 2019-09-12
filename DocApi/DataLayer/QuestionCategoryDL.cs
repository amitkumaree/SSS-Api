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
        internal List<QUESTION_CATEGORY> GetAllQuestionCategory(int subDomId)
        {
            var questionCategory = new List<QUESTION_CATEGORY>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionCat, subDomId);
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


        internal QUESTION_CATEGORY_LIST GetQuestionCategory(int subDomId)
        {
            var questionCategoryList = new QUESTION_CATEGORY_LIST();

            var questionCategory = new List<QUESTION_CATEGORY>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionCatBySubDomId , subDomId);
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

            questionCategoryList.QuestionCategory = questionCategory;

            return questionCategoryList; // questionCategory;
        }


        internal void InsertQuestionCategory(QUESTION_CATEGORY qc)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertQuestionCategory,
                                          qc.DOM_ID.Value,
                                          qc.SUB_DOM_ID.Value ,
                                          string.Concat("'", qc.NAME, "'"),
                                          string.Concat("'", qc.DESCRIPTION, "'"),
                                          qc.SEQ_NO.HasValue ? qc.SEQ_NO.Value : 0 ,
                                          string.Concat("'", string.IsNullOrWhiteSpace(qc.DEL_FLG) ? "N" : qc.DEL_FLG, "'"), //dm.DEL_FLG
                                          string.Concat("'", string.IsNullOrWhiteSpace(qc.ORGL_USER) ? "ADMIN" : qc.ORGL_USER, "'"),
                                          "SYSDATE()"
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void UpdateQuestionCategory(QUESTION_CATEGORY qc)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.UpdateQuestionCategory,
                                          qc.DOM_ID.HasValue ?  Convert.ToString(qc.DOM_ID.Value) : "DOM_ID" ,
                                          qc.SUB_DOM_ID.HasValue ?  Convert.ToString(qc.SUB_DOM_ID.Value) : "SUB_DOM_ID" ,
                                          string.IsNullOrWhiteSpace(qc.NAME) ? "NAME" : string.Concat("'", qc.NAME, "'"),
                                          string.IsNullOrWhiteSpace(qc.DESCRIPTION) ? "DESCRIPTION" : string.Concat("'", qc.DESCRIPTION, "'"),
                                          qc.SEQ_NO.HasValue ? Convert.ToString(qc.SEQ_NO.Value) : "SEQ_NO" ,
                                          string.IsNullOrWhiteSpace(qc.UPDT_USER) ? "UPDT_USER" : string.Concat("'", qc.UPDT_USER, "'"),
                                          "SYSDATE()",
                                          qc.QC_ID.Value 
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void DeleteQuestionCategory(int qcId)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.DeleteQuestionCategory,
                                          qcId
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

    }
}