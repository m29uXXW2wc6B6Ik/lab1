// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the UnitTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

/// <summary>
/// The UnitTestProject namespace.
/// </summary>
namespace UnitTestProject
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;
    using Stelmashok.Generic.Generic;

    /// <summary>
    /// Class UnitTest1.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the method1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            IGenericContravariant<BaseModel> contravariantBaseModel = new ContravariantBaseModel();
            IGenericContravariant<ChildModel> contravariantChildModel = new ContravariantChildModel();
            contravariantChildModel = contravariantBaseModel;
            contravariantBaseModel = (IGenericContravariant<BaseModel>)contravariantChildModel;
        }

        /// <summary>
        /// Tests the method2.
        /// </summary>
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
