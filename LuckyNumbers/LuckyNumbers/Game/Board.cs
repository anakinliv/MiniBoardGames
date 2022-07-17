using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Board
    {
        Tile[,] spaces;
        public Board()
        {
            spaces = new Tile[LuckyNumbersConst.BoardWidth, LuckyNumbersConst.BoardHeight];
        }

        public void Clear()
        {
            for (int i = 0; i < LuckyNumbersConst.BoardWidth; i++)
            {
                for (int j = 0; j < LuckyNumbersConst.BoardHeight; j++)
                {
                    spaces[i, j] = null;
                }
            }
        }

        public void Init(List<Tile> startTokens)
        {
            for (int i = 0; i < startTokens.Count; i++)
            {
                spaces[i, i] = startTokens[i];
            }
        }

        public void ShowBoard()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < LuckyNumbersConst.BoardHeight; i++)
            {
                for (int j = 0; j < LuckyNumbersConst.BoardWidth; j++)
                {
                    if (spaces[i, j] == null)
                        sb.Append("[--]");
                    else
                        sb.Append(string.Format("[{0:d2}]", spaces[i, j].val));
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        public bool TryPut(Tile tile, int row, int column, out Tile oldTile)
        {
            oldTile = null;
            for (int i = 0; i < column; i++)
            {
                if(spaces[row, i] != null)
                {
                    if (spaces[row, i].val > tile.val) return false;
                }
            }
            for (int i = column + 1; i < LuckyNumbersConst.BoardWidth; i++)
            {
                if (spaces[row, i] != null)
                {
                    if (spaces[row, i].val < tile.val) return false;
                }
            }
            for (int i = 0; i < row; i++)
            {
                if (spaces[i, column] != null)
                {
                    if (spaces[i, column].val > tile.val) return false;
                }
            }
            for (int i = row+1; i < LuckyNumbersConst.BoardHeight; i++)
            {
                if (spaces[i, column] != null)
                {
                    if (spaces[i, column].val < tile.val) return false;
                }
            }

            oldTile = spaces[row, column];
            spaces[row, column] = tile;
            return true;
        }
    }
}
