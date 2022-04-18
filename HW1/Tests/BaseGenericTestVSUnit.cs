using CognizantSoftvision.Maqs.BaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// BaseGenericTestVSUnit test class with VS unit
    /// </summary>
    [TestClass]
    public class BaseGenericTestVSUnit : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void SampleTest()
        {
            this.TestObject.Log.LogMessage("Start Test");
            Assert.IsTrue(true, "True is Not True");
        }
        
        /// <summary>
        /// Extra credit test
        /// </summary>
        [TestMethod]
        public void ExtraCredit()
        {
            this.TestObject.Log.LogMessage("Start Test");
            int a = 1;
            int b = 2;
            bool sum = (a + a).Equals(b);
            Assert.IsTrue(sum, "1+1=/=2");
        }        
    }

    /// <summary>
    /// Extra credit test class with VS unit
    /// </summary>
    [TestClass]
    public class ExtraExtraCredit : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void SampleTest()
        {
            this.TestObject.Log.LogMessage("Start Test");
            Assert.IsTrue(true, "True is Not True");
        }
    }  
}