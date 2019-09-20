using DocApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocApi.DataLayer;

namespace DocApi.LogicLayer
{

    public class SubQuestionCategoryAndChildsControllerLL
    {

        private List<SUB_QUESTION_CATEGORY> SUB_QUESTION_CATEGORY_LIST = new List<SUB_QUESTION_CATEGORY>();
        private List<QUESTION_ITEM> QUESTION_ITEM_LIST = new List<QUESTION_ITEM>();
        private List<QUESTION_CONTROL> QUESTION_CONTROL_LIST = new List<QUESTION_CONTROL>();

        private SubQuestionCategoryDL _dacSQC = new SubQuestionCategoryDL();
        private QuestionItemDL _dacQI = new QuestionItemDL();
        private QuestionControlDL _dacQC = new QuestionControlDL();
        
        

        internal List<SUB_QUESTION_CATEGORY_AND_CHILD> SubQuestionCategoryAndChilds(int qcId)
        {

            List<SUB_QUESTION_CATEGORY_AND_CHILD> sqcs = new List<SUB_QUESTION_CATEGORY_AND_CHILD>();
            SUB_QUESTION_CATEGORY_AND_CHILD sqc;

            List<QUESTION_ITEM_AND_CHILD> qics = new List<QUESTION_ITEM_AND_CHILD>();
            QUESTION_ITEM_AND_CHILD qic;



            SUB_QUESTION_CATEGORY_LIST = _dacSQC.GetSubQuestionCategory(qcId);
            QUESTION_ITEM_LIST = _dacQI.GetQuestionItem(0);
            QUESTION_CONTROL_LIST = _dacQC.GetQuestionControl(0);

            foreach (var s in SUB_QUESTION_CATEGORY_LIST)
            {
                sqc = new SUB_QUESTION_CATEGORY_AND_CHILD();
                sqc.SUB_QUESTION_CATEGORY = s;

                var questionItems = (from qil in QUESTION_ITEM_LIST
                                    where qil.SQC_ID == s.SQC_ID
                                    select qil).ToList();

                foreach(var q in questionItems)
                {
                    qic = new QUESTION_ITEM_AND_CHILD();

                    qic.QUESTION_ITEM = q;

                    var questionControls = (from qc in QUESTION_CONTROL_LIST
                                            where qc.QI_ID == q.QI_ID
                                            select qc).ToList();

                    qic.QUESTION_CONTROL.AddRange(questionControls);

                    qics.Add(qic);
                }

                sqc.QUESTION_ITEM_AND_CHILDs.AddRange(qics);

                sqcs.Add(sqc);
            }                

            return sqcs;
        }

    }
}