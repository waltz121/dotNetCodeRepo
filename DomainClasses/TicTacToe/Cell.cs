using System;
using System.Collections.Generic;
using System.Text;

namespace DomainClasses.TicTacToe
{
    public class Cell
    {
        Symbol _symbol;

        public Symbol Symbol { get { return _symbol; } set { _symbol = value; } }

        public Cell()
        {
            _symbol = Symbol.EMPTY;
        }

        public bool isEmpty()
        {
            if(_symbol == Symbol.EMPTY)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
