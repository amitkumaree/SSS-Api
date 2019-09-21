using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{
    public class QuestionCategoryAndChildsLL
    {
        private List<QUESTION_CATEGORY> QUESTION_CATEGORY_LIST = new List<QUESTION_CATEGORY>();
        private List<SUB_QUESTION_CATEGORY> SUB_QUESTION_CATEGORY_LIST = new List<SUB_QUESTION_CATEGORY>();
        private List<QUESTION_ITEM> QUESTION_ITEM_LIST = new List<QUESTION_ITEM>();
        private List<QUESTION_CONTROL> QUESTION_CONTROL_LIST = new List<QUESTION_CONTROL>();

        private QuestionCategoryDL _dacQCa = new QuestionCategoryDL();
        private SubQuestionCategoryDL _dacSQC = new SubQuestionCategoryDL();
        private QuestionItemDL _dacQI = new QuestionItemDL();
        private QuestionControlDL _dacQC = new QuestionControlDL();



        internal List<QUESTION_CATEGORY_AND_CHILD> QuestionCategoryAndChilds(int subDomId)
        {
            List<QUESTION_CATEGORY_AND_CHILD> qcs = new List<QUESTION_CATEGORY_AND_CHILD>();
            QUESTION_CATEGORY_AND_CHILD qc;


            List<SUB_QUESTION_CATEGORY_AND_CHILD> sqcs = new List<SUB_QUESTION_CATEGORY_AND_CHILD>();
            SUB_QUESTION_CATEGORY_AND_CHILD sqc;

            List<QUESTION_ITEM_AND_CHILD> qics = new List<QUESTION_ITEM_AND_CHILD>();
            QUESTION_ITEM_AND_CHILD qic;


            QUESTION_CATEGORY_LIST = _dacQCa.GetQuestionCategory(subDomId);
            SUB_QUESTION_CATEGORY_LIST = _dacSQC.GetSubQuestionCategory(0);
            QUESTION_ITEM_LIST = _dacQI.GetQuestionItem(0);
            QUESTION_CONTROL_LIST = _dacQC.GetQuestionControl(0);

            foreach (var q in QUESTION_CATEGORY_LIST)
            {
                qc = new QUESTION_CATEGORY_AND_CHILD();
                qc.QUESTION_CATEGORY = q;

                var subQuestCats = (from sqcl in SUB_QUESTION_CATEGORY_LIST
                                    where sqcl.QC_ID == q.QC_ID
                                    select sqcl).ToList();

                foreach (var s in subQuestCats)
                {
                    sqc = new SUB_QUESTION_CATEGORY_AND_CHILD();
                    sqc.SUB_QUESTION_CATEGORY = s;

                    var questionItems = (from qil in QUESTION_ITEM_LIST
                                         where qil.SQC_ID == s.SQC_ID
                                         select qil).ToList();

                    foreach (var qi in questionItems)
                    {
                        qic = new QUESTION_ITEM_AND_CHILD();

                        qic.QUESTION_ITEM = qi;

                        var questionControls = (from qcl in QUESTION_CONTROL_LIST
                                                where qcl.QI_ID == qi.QI_ID
                                                select qcl).ToList();

                        qic.QUESTION_CONTROLs.AddRange(questionControls);

                        qics.Add(qic);
                    }

                    sqc.QUESTION_ITEM_AND_CHILDs.AddRange(qics);

                    sqcs.Add(sqc);
                }

                qc.SUB_QUESTION_CATEGORY_AND_CHILDs.AddRange(sqcs);
                qcs.Add(qc);
            }

            return qcs;
        }

    }
}