using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Tile
    {
        public int val;
        int group;
        public Tile(int val, int group)
        {
            this.val = val;
            this.group = group;
        }
    }
}
