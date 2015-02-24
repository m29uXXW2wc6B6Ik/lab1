using lab1.Base;
using lab1.Cov_and_Contr;
using lab1.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IGeneric1<BaseModel> generic1 = new Generic11();
            IGeneric1<ChildModel> generic2 = new Generic12();
            //generic1 = generic2;
            generic2 = generic1;
        }
        [TestMethod]
        public void TestMethod2()
        {
            IGeneric2<BaseModel> generic1 = new Generic21();
            IGeneric2<ChildModel> generic2 = new Generic22();
            generic1 = generic2;
            //generic2 = generic1;
        }
    }
}
