// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the UnitTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UnitTestProject
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;
    using Stelmashok.Generic.Generic;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IGenericContravariant<BaseModel> contravariantBaseModel = new ContravariantBaseModel();
            IGenericContravariant<ChildModel> contravariantChildModel = new ContravariantChildModel();
            contravariantChildModel = contravariantBaseModel;
            contravariantBaseModel = (IGenericContravariant<BaseModel>)contravariantChildModel;
        }
 
        [TestMethod]
        public void TestMethod2()
        {
            IGenericCovariant<BaseModel> covariantBaseModel = new CovariantBaseModel();
            IGenericCovariant<ChildModel> covariantChildModel = new CovariantChildModel();
            covariantBaseModel = covariantChildModel;
            covariantChildModel = (IGenericCovariant<ChildModel>)covariantBaseModel;
            
        }
    }
}
