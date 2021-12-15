using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PacmanGameLogic
{
    [TestClass]
    //creates a test class
    public class GamestateTest
    {
        [TestMethod]
        //creates a test method to test game state
        public void TestGameState()
        { 
            //actual functionality
            GamestateTest gamestate = new GamestateTest();
            //expected functionality
            gamestate.Equals(gamestate);
            //Assert Functionality
            Assert.Equals(gamestate, gamestate);    

        
        }
    }
}
