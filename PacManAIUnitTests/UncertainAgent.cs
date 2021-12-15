using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PacManAI
{
    [TestClass]
    //creates a test class
    public class UncertainAgent
    {
        [TestMethod]
        //creates a test method
        public void TestMethod1()
        {
            //actual functionality
            UncertainAgent agent = new UncertainAgent();
            //expected functionality
            var actual = agent.GetType();
            //Asserts Functionality
            Assert.IsNotNull(actual);
        }
    }
}
