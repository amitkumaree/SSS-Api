using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocApi.DataLayer
{
    internal sealed class QuestionControlAndControlMasterDL
    {
        string _statement;
        internal List<QUESTION_CONTROL_AND_CONTROL_MASTER> GetQuestionControlAndMaster(int qiId)
        {
            var QuestionControlAndMaster = new List<QUESTION_CONTROL_AND_CONTROL_MASTER>();
            using (var connection = MySqlDbConnection.NewConnection)
            {
                _statement = string.Format(MySQLquery.GetQuestionControlAndMaster,
                                           qiId > 0 ? Convert.ToString(qiId) : "QI_ID");
                //qiId);
                using (var command = MySqlDbConnection.Command(connection, _statement))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var questControlMaster = new QUESTION_CONTROL_AND_CONTROL_MASTER();

                                questControlMaster.QCT_ID = UtilityDL.CheckNull<int>(reader["QCT_ID"]);
                                questControlMaster.QI_ID = UtilityDL.CheckNull<int>(reader["QI_ID"]);
                                questControlMaster.SQC_ID = UtilityDL.CheckNull<int>(reader["SQC_ID"]);
                                questControlMaster.QC_ID = UtilityDL.CheckNull<int>(reader["QC_ID"]);

                                questControlMaster.DOM_ID = UtilityDL.CheckNull<int>(reader["DOM_ID"]);

                                questControlMaster.SUB_DOM_ID = UtilityDL.CheckNull<int>(reader["SUB_DOM_ID"]);

                                questControlMaster.NAME = UtilityDL.CheckNull<string>(reader["NAME"]);

                                questControlMaster.LABEL = UtilityDL.CheckNull<string>(reader["LABEL"]);

                                questControlMaster.HINT = UtilityDL.CheckNull<string>(reader["HINT"]);

                                questControlMaster.OTHDESC = UtilityDL.CheckNull<string>(reader["OTHDESC"]);

                                questControlMaster.LISTOFVAL = UtilityDL.CheckNull<string>(reader["LISTOFVAL"]);

                                questControlMaster.CONTROL_ID = UtilityDL.CheckNull<int>(reader["CONTROL_ID"]);

                                questControlMaster.SEQ_NO = UtilityDL.CheckNull<int>(reader["SEQ_NO"]);



                                questControlMaster.CONTROL_TYP = UtilityDL.CheckNull<string>(reader["CONTROL_TYP"]);

                                questControlMaster.CONTROL_NAME = UtilityDL.CheckNull<string>(reader["CONTROL_NAME"]);

                                questControlMaster.CONTROL_LABEL = UtilityDL.CheckNull<string>(reader["CONTROL_LABEL"]);

                                questControlMaster.SAMPLE_PIC = UtilityDL.CheckNull<string>(reader["SAMPLE_PIC"]);



                                QuestionControlAndMaster.Add(questControlMaster);
                            }
                        }
                    }
                }

                return QuestionControlAndMaster;
            }

        }

        

    }
}