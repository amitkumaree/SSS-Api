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
        internal List<QUESTION_ITEM> GetQuestionItem(int sqcId)
        {
            var QuestionItem = new List<QUESTION_ITEM>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionItem ,
                                           sqcId > 0 ? Convert.ToString(sqcId) : "SQC_ID"); 
                                           //sqcId);
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
                                questItem.SEQ_NO = UtilityDL.CheckNull<int>(reader["SEQ_NO"]);


                                questItem.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);
                                questItem.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);
                                questItem.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);
                                questItem.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);
                                questItem.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);

                                QuestionItem.Add(questItem);
                            }
                        }
                    }
                }

                return QuestionItem;
            }           

        }


        internal void InsertQuestionItem(QUESTION_ITEM qi)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertQuestionItem,
                                          qi.SQC_ID.Value  ,
                                          qi.QC_ID.Value ,
                                          qi.DOM_ID.Value ,
                                          qi.SUB_DOM_ID.Value ,
                                          string.Concat("'", qi.NAME, "'"),
                                          string.Concat("'", qi.DESCRIPTION, "'"),
                                          qi.SEQ_NO,
                                          string.Concat("'", string.IsNullOrWhiteSpace(qi.DEL_FLG) ? "N" : qi.DEL_FLG, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(qi.ORGL_USER) ? "ADMIN" : qi.ORGL_USER, "'"),
                                          "SYSDATE()"
                                          );
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void UpdateQuestionItem(QUESTION_ITEM qi)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.UpdateQuestionItem,
                                          qi.SQC_ID.HasValue ? Convert.ToString(qi.SQC_ID.Value) : "SQC_ID" ,
                                          qi.QC_ID.HasValue ?  Convert.ToString(qi.QC_ID.Value) : "QC_ID" ,
                                          qi.DOM_ID.HasValue ? Convert.ToString(qi.DOM_ID.Value) : "DOM_ID" ,
                                          qi.SUB_DOM_ID.HasValue ? Convert.ToString(qi.SUB_DOM_ID.Value) : "SUB_DOM_ID" ,
                                          string.IsNullOrWhiteSpace(qi.NAME) ? "NAME" : string.Concat("'", qi.NAME, "'"),
                                          string.IsNullOrWhiteSpace(qi.DESCRIPTION) ? "DESCRIPTION" : string.Concat("'", qi.DESCRIPTION, "'"),
                                          qi.SEQ_NO.HasValue ?  Convert.ToString(qi.SEQ_NO.Value) : "SEQ_NO" ,
                                          string.IsNullOrWhiteSpace(qi.UPDT_USER) ? "UPDT_USER" : string.Concat("'", qi.UPDT_USER, "'"),
                                          "SYSDATE()",
                                          qi.QI_ID.Value
                                          );

               // UPDATE QUESTION_ITEM SET SQC_ID = { 0 }, QC_ID = { 1 }, DOM_ID = { 2 }, SUB_DOM_ID = { 3 }, NAME = { 4 }, DESCRIPTION = { 5 }, SEQ_NO = { 6 }, UPDT_USER = { 7 }, UPDT_STAMP = { 8 } WHERE QI_ID = { 9 }

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void DeleteQuestionItem(int qiId)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.DeleteQuestionItem,
                                          qiId
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }


    }
}