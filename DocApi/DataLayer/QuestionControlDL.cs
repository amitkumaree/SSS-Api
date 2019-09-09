using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class QuestionControlDL
    {
        string _statement;
        internal List<QUESTION_CONTROL> GetAllQuestionControl(int qiId)
        {
            var QuestionControl = new List<QUESTION_CONTROL>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionControl, qiId);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var questControl = new QUESTION_CONTROL();
                                
                                questControl.QCT_ID = UtilityDL.CheckNull<int>(reader["QCT_ID"]);
                                questControl.QI_ID = UtilityDL.CheckNull<int>(reader["QI_ID"]);
                                questControl.SQC_ID = UtilityDL.CheckNull<int>(reader["SQC_ID"]);
                                questControl.QC_ID = UtilityDL.CheckNull<int>(reader["QC_ID"]);

                                questControl.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);

                                questControl.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);

                                questControl.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);

                                questControl.LABEL = UtilityDL.CheckNull<string>(reader["LABEL"]);

                                questControl.HINT = UtilityDL.CheckNull<string>(reader["HINT"]);

                                questControl.OTHDESC = UtilityDL.CheckNull<string>(reader["OTHDESC"]);

                                questControl.LISTOFVAL = UtilityDL.CheckNull<string>(reader["LISTOFVAL"]);

                                questControl.CONTROL_ID = UtilityDL.CheckNull<int>(reader["CONTROL_ID"]);
                                
                                questControl.SEQ_NO = UtilityDL.CheckNull<int>(reader["SEQ_NO"]);

                                questControl.DEL_FLG = UtilityDL.CheckNull<string>(reader["DEL_FLG"]);

                                questControl.ORGL_USER = UtilityDL.CheckNull<string>(reader["ORGL_USER"]);

                                questControl.ORGL_STAMP = UtilityDL.CheckNull<DateTime>(reader["ORGL_STAMP"]);

                                questControl.UPDT_USER = UtilityDL.CheckNull<string>(reader["UPDT_USER"]);

                                questControl.UPDT_STAMP = UtilityDL.CheckNull<DateTime>(reader["UPDT_STAMP"]);

                                QuestionControl.Add(questControl);
                            }
                        }
                    }
                }

                return QuestionControl;
            }

        }

        internal void InsertQuestionControl(QUESTION_CONTROL qc)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.InsertQuestionControl,
                                          qc.QI_ID.Value ,
                                          qc.SQC_ID.Value,
                                          qc.QC_ID.Value ,
                                          qc.DOM_ID.Value ,
                                          qc.SUB_DOM_ID.Value ,
                                          string.Concat("'", qc.NAME, "'"),
                                          string.Concat("'", qc.LABEL, "'"),
                                          string.Concat("'", qc.HINT, "'"), 
                                          string.Concat("'", qc.OTHDESC, "'"),
                                          string.Concat("'", qc.LISTOFVAL, "'"),
                                          qc.CONTROL_ID.Value,
                                          qc.SEQ_NO.Value,
                                          string.Concat("'", string.IsNullOrWhiteSpace(qc.DEL_FLG) ? "N" : qc.DEL_FLG, "'"),
                                          string.Concat("'", string.IsNullOrWhiteSpace(qc.ORGL_USER) ? "ADMIN" : qc.ORGL_USER, "'"),
                                          "SYSDATE()"
                                          );

                //INSERT INTO QUESTION_CONTROL(QI_ID, SQC_ID, QC_ID, DOM_ID, SUB_DOM_ID, NAME, LABEL, HINT, OTHDESC, LISTOFVAL, CONTROL_ID, SEQ_NO, DEL_FLG, ORGL_USER, ORGL_STAMP) VALUES(  { 0} , { 1} , { 2},  { 3} , { 4} , { 5}, { 6}, { 7}, { 8} , { 9} ,{ 10} , { 11} ,{ 12}, { 13}, { 14})

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }
            }
        }

        internal void UpdateQuestionControl(QUESTION_CONTROL qc)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.UpdateQuestionControl,
                                          qc.QI_ID.HasValue ? Convert.ToString(qc.QI_ID.Value) : "QI_ID" ,
                                          qc.SQC_ID.HasValue ?  Convert.ToString(qc.SQC_ID.Value) : "SQC_ID" ,
                                          qc.QC_ID.HasValue  ?  Convert.ToString(qc.QC_ID.Value) : "QC_ID" ,
                                          qc.DOM_ID.HasValue ?  Convert.ToString(qc.DOM_ID.Value) : "DOM_ID" ,
                                          qc.SUB_DOM_ID.HasValue ?  Convert.ToString(qc.SUB_DOM_ID.Value) : "SUB_DOM_ID" ,
                                          string.IsNullOrWhiteSpace(qc.NAME) ? "NAME" : string.Concat("'", qc.NAME, "'"),
                                          string.IsNullOrWhiteSpace(qc.LABEL) ? "LABEL" : string.Concat("'", qc.LABEL, "'"),
                                          string.IsNullOrWhiteSpace(qc.HINT) ? "HINT" : string.Concat("'", qc.HINT, "'"),
                                          string.IsNullOrWhiteSpace(qc.OTHDESC) ? "OTHDESC" : string.Concat("'", qc.OTHDESC, "'"),
                                          string.IsNullOrWhiteSpace(qc.LISTOFVAL) ? "LISTOFVAL" : string.Concat("'", qc.LISTOFVAL, "'"),
                                          qc.CONTROL_ID.HasValue ?  Convert.ToString(qc.CONTROL_ID.Value) : "CONTROL_ID",
                                          qc.SEQ_NO.HasValue ? Convert.ToString(qc.SEQ_NO.Value) : "SEQ_NO" ,
                                          string.IsNullOrWhiteSpace(qc.UPDT_USER) ? "UPDT_USER" : string.Concat("'", qc.UPDT_USER, "'"),
                                          "SYSDATE()",
                                          qc.QCT_ID.Value 
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

        internal void DeleteQuestionControl(int qctId)
        {
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.DeleteQuestionControl,
                                          qctId
                                          );

                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    command.ExecuteNonQuery();

                }


            }
        }

    }
}