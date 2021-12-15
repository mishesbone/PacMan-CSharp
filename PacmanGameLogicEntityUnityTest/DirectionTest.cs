using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PacmanGameLogic
{
    [TestClass]
    //creates a test class
    public class DirectionTest
    {
        [TestMethod]
        //creates a test method
        public void TestingGhostMove()
        {
            //Actual functionality
            DirectionTest directionTest = new DirectionTest();
            //expected functionality
            directionTest.TestingGhostMove();
            //Asserts Fuctionality
            Assert.IsNotNull(directionTest);    

        }
    }
}
