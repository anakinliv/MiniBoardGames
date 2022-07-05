using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Player
    {
        Board board;
        public Player()
        {
            board = new Board();
        }

        internal void InitBoard(List<Token> startTokens)
        {
            board.Clear();
            board.Init();
        }
    }
}
