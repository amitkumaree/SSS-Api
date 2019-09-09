using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            string st = "UPDATE DOMAIN SET NAME={1}   , DESCRIPTION={2}, UPDT_USER={3}  ,UPDT_STAMP={4} WHERE  ID={0}";
            string NAME = "Rahul";
            string DESCRIPTION = null;
            string UPDT_USER = null;
            int id = 4;


            string st2 = string.Format(st, id, string.IsNullOrWhiteSpace(NAME) ? "NAME" : string.Concat("'", NAME, "'"),
                                           string.IsNullOrWhiteSpace(DESCRIPTION) ? "DESCRIPTION" : string.Concat("'", DESCRIPTION, "'"),
                                           string.IsNullOrWhiteSpace(UPDT_USER) ? "UPDT_USER" : string.Concat("'", UPDT_USER, "'"),
                                           "SYSDATE()" // string.Concat("'", "SYSDATE()", "'")
                                        );

            Console.WriteLine(st2);

        }
    }
} 
