using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PacmanGameLogic
{
    [TestClass]
    //creates a Test class
    public class BlueGhost
    {
        [TestMethod]
        //creates a test method
        public void BlueGhostTest()
        {
            //actual functionality
            BlueGhost blueGhost = new BlueGhost();  
            //expected functionality
            blueGhost.BlueGhostTest();
            //Asserts Functionality
            Assert.IsNotNull(blueGhost);

        }
    }
}
