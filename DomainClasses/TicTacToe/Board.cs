using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DomainClasses.TicTacToe
{
    public class Board
    {
        private Cell[,] _grid;
        private int _size;

        public Board(int size)
        {
            _size = size;
            _grid = new Cell[size, size];
            Initialize();
        }

        private void ValidatePosition(int row, int col)
        {
            if(row < 0 || row >= _size || col < 0 || col >= _size)
            {
                throw new InvalidMoveException(
                    $"Position ({row}, {col}) is out of bounds");
            }
        }

        private void Initialize()
        {
            for(int i = 0; i < _size; i++)
            {
                for(int j = 0; j < _size; j++)
                {
                    _grid[i, j] = new Cell();
                }
            }
        }

        public void placeSymbol(int row, int col, Symbol symbol) 
        {
            _grid[row, col].Symbol = symbol;
        }

        public bool isFull()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    if (_grid[i, j].isEmpty())
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public Cell GetCell(int row, int col)
        {
            ValidatePosition(row, col);
            return _grid[row, col];
        }

        public void printBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Console.WriteLine($" {_grid[i, j].Symbol.GetDisplayChar()}");
                    if (j < _size - 1) Console.Write("|");
                }
                Console.WriteLine();
                if(i < _size - 1)
                {
                    Console.WriteLine(new string('-', _size * 4 - 1));
                }
            }
            Console.WriteLine();
        }

        public bool isCellEmpty(int row, int col)
        {
            ValidatePosition(row, col);
            return _grid[row, col].isEmpty();
        }
    }
}
