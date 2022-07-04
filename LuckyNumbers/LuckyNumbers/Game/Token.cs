using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Token
    {
        int val;
        int group;
        public Token(int val, int group)
        {
            this.val = val;
            this.group = group;
        }
    }
}
