using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PacManGameLogic
{
    [TestClass]
    //creates a test class to test BasePacman
    public class BasePacman
    {
        [TestMethod]
        //creates a test method
        public void GeneratesSessionId()
        {
            //actual functionality
            BasePacman basePacman = new BasePacman();
            //expected functionality
            var basepacman = basePacman.Equals(basePacman);
            //Assert functionality
            Assert.IsNotNull(basepacman);
            
        }
    }
}
