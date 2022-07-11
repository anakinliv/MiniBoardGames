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

        internal void InitBoard(List<Tile> startTokens)
        {
            board.Clear();
            startTokens.Sort((a, b) => { return a.val - b.val; });
            board.Init(startTokens);
        }

        internal void ShowInfo()
        {
            board.ShowBoard();
        }
    }
}
