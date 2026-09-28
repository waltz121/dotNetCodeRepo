using System;
using System.Collections.Generic;
using System.Text;

namespace DomainClasses.TicTacToe
{
    public class Game
    {
        private readonly Board _board;
        private readonly Player[] _players;
        private int _currentPlayerIndex;
        private readonly object _lock = new object();

        public GameStatus Status { get; private set; }
        public Board Board => _board;
        public Player CurrentPlayer => _players[_currentPlayerIndex];

        public Game(Player player1, Player player2, int boardSize)
        {
            _board = new Board(boardSize);
            _players = new[] { player1, player2 };
            _currentPlayerIndex = 0;
            Status = GameStatus.IN_PROGRESS;
        }

        public void MakeMove(int row, int col)
        {
            lock(_lock)
            {
                if(Status != GameStatus.IN_PROGRESS)
                {
                    throw new InvalidMoveException("Game is already over!");
                }

                if (!_board.isCellEmpty(row, col))
                {
                    throw new InvalidMoveException(
                        $"Cell ({row}, {col}) is already occupied");
                }

                Player currentPlayer = _players[_currentPlayerIndex];
                _board.placeSymbol(row, col, currentPlayer.Symbol);

                if(CheckWin(row, col, currentPlayer.Symbol))
                {
                    Status = currentPlayer.Symbol == Symbol.X
                        ? GameStatus.WINNER_X
                        : GameStatus.WINNER_O;
                    return;
                }

                if (_board.isFull())
                {
                    Status = GameStatus.DRAW;
                    return;
                }

                _currentPlayerIndex = (_currentPlayerIndex + 1) % 2;
            }
        }

        private bool CheckWin(int row, int col, Symbol symbol)
        {
            int size = _board.Size;

            bool win = true;
            for (int c = 0; c < size; c++)
            {
                if(_board.GetCell(row, c).Symbol != symbol) { win = false; break; }
            }
            if(win) { return true; }

            win = true;
            for (int r = 0; r < size; r++)
            {
                if (_board.GetCell(r, col).Symbol != symbol) { win = false; break; }
            }
            if (win) return true;

            if(row == col)
            {
                win = true;
                for (int i = 0; i < size; i++)
                {
                    if (_board.GetCell(i, i).Symbol != symbol) { win = false; break; }
                }
                if (win) return true;
            }

            if (row + col == size - 1)
            {
                win = true;
                for (int i = 0; i < size; i++)
                {
                    if (_board.GetCell(i, size - 1 - i).Symbol != symbol) { win = false; break; }
                }
                if (win) return true;
            }

            return false;
        }

        public Player GetWinner()
        {
            if(Status == GameStatus.WINNER_X)
            {
                return _players[0].Symbol == Symbol.X ? _players[0] : _players[1];
            }
            else if (Status == GameStatus.WINNER_O)
            {
                return _players[0].Symbol == Symbol.O ? _players[0] : _players[1];
            }
            return null;
        }

        public void PrintBoard()
        {
            _board.printBoard();
        }
    }
}
