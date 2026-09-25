using System;
using System.Collections.Generic;
using System.Text;

namespace DomainClasses.TicTacToe
{
    public enum Symbol
    {
        X,
        O,
        EMPTY
    }

    static class SymbolExtensions
    {
        public static char GetDisplayChar(this Symbol symbol)
        {
            return symbol switch
            {
                Symbol.X => 'X',
                Symbol.O => 'O',
                Symbol.EMPTY => '_',
                _ => throw new ArgumentOutOfRangeException(nameof(symbol))
            };
        }
    }
}
