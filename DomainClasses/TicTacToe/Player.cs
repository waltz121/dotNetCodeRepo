using System;
using System.Collections.Generic;
using System.Text;

namespace DomainClasses.TicTacToe
{
    public class Player
    {
        String _name;
        Symbol _symbol;

        public string Name { get { return _name; } }
        public Symbol Symbol { get { return _symbol; } }
        public Player(string name, Symbol symbol)
        {
            if(symbol == Symbol.EMPTY)
            {
                throw new ArgumentException("Player cannot have Empty symbol", nameof(symbol));
            }
            _name = name;
            _symbol = symbol;
        }
    }
}
