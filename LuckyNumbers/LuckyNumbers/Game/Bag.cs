using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Bag
    {
        public List<Token> tokens;

        Random rnd;

        public Bag(Random rnd)
        {
            tokens = new List<Token>();
            this.rnd = rnd;
        }

        public void PutIn(Token token)
        {
            tokens.Add(token);
        }

        public Token TakeOut()
        {
            if (tokens.Count == 0)
                return null;
            var token = tokens[rnd.Next(tokens.Count)];
            tokens.RemoveAt(rnd.Next(tokens.Count));
            return token;
        }
    }
}
