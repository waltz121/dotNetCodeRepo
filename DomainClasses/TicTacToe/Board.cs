using System;
using System.Collections.Generic;
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
        }
    }
}
