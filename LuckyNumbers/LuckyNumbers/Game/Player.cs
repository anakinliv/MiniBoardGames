using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Player
    {
        Board board;
        Tile hand;
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
            Console.WriteLine($"hand: {hand?.val:D2}");
            board.ShowBoard();
        }

        public void Take(Tile tile)
        {
            hand = tile;
        }

        public void Put(int row,int column)
        {
            if(board.TryPut(hand,row,column,out var oldTile))
            {
                if(oldTile != null)
                {
                    LuckyNumbersGame.Instance.pool.Add(oldTile);
                }
                hand = null;
            }
        }
    }
}
