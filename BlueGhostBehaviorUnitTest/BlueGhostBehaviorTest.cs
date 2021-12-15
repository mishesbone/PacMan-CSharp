using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BlueGhostBehaviorUnitTest
{
    [TestClass]
    public class BlueGhostBehaviorTest
    {
        [TestMethod]
        public void TestingBlueGhost()
        {
            //Actual functionality
            BlueGhostBehaviorTest blueghost=new BlueGhostBehaviorTest();
            //expected functionality
            blueghost.MemberwiseClone();
            //Asserts Functionality
             Assert.AreEqual(blueghost, blueghost);
        }
    }
}
