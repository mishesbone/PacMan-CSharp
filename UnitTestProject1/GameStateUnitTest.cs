using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PacmanGameLogic
{
    [TestClass]
    //test class created
    public class GameStateUnitTest
    {
        [TestMethod]
        //test method testing game state
        public void TestsGameState()
        {
            //actual fuctuntionality
            GameStateUnitTest gamestate=new GameStateUnitTest();
            //expected functionality
            gamestate.Equals(gamestate);
            //Asserts Functionality
            Assert.Equals(gamestate, gamestate);  

        }
        //testing load maze game state functionality
        public void TestingLoadMaze()
        {
            //actual functionality
            GameStateUnitTest loadmaze=new GameStateUnitTest(); 
            //expected functionality
            loadmaze.Equals(loadmaze);
            //Asserts Functionality
            Assert.Equals(loadmaze,loadmaze);
        }
        
    }
}
