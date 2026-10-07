using DomainClasses.TicTacToe;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    public class TicTacToeSpecs
    {
        Game tictactoeGame;

        [SetUp]
        public void SetUp()
        {
            Player player1 = new Player("Walter", Symbol.O);
            Player player2 = new Player("Wesley", Symbol.X);
            tictactoeGame = new Game(player1, player2, 3);
        }

        [Test]
        public void DemoGameplay()
        {
            tictactoeGame.MakeMove(0, 0);  
            tictactoeGame.MakeMove(1, 0);  
            tictactoeGame.MakeMove(0, 1);  
            tictactoeGame.MakeMove(1, 1);  
            tictactoeGame.MakeMove(0, 2);
            Assert.AreEqual(tictactoeGame.GetWinner().Name, "Walter");
        }
    }
}
