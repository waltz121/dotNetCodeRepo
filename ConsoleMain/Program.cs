using DomainClasses;
using DomainClasses.TicTacToe;

Player player1 = new Player("Walter", Symbol.O);
Player player2 = new Player("Wesley", Symbol.X);
Game game = new Game(player1, player2, 3);

game.MakeMove(0,0);
game.MakeMove(1,0);
game.MakeMove(0,1);
game.MakeMove(1,1);
game.MakeMove(0,2);
var player = game.GetWinner();
game.PrintBoard();

Console.WriteLine($"Winner is: {player.Name}");

