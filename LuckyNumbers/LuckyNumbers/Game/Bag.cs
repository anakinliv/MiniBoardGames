using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Bag
    {
        public List<Token> tokens;

        public Bag()
        {
            tokens = new List<Token>();
        }

        public void PutIn(Token token)
        {
            tokens.Add(token);
        }
    }
}
