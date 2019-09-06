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
        internal List<QUESTION_CONTROL> GetAllQuestionControl()
        {
            var QuestionControl = new List<QUESTION_CONTROL>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionControl);
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
    }
}