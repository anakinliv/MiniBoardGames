using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class Board
    {
        Node[,] nodes;
        public Board()
        {
            nodes = new Node[LuckyNumbersConst.BoardWidth,LuckyNumbersConst.BoardHeight];
            for(int i = 0; i < LuckyNumbersConst.BoardWidth; i++)
            {
                for (int j = 0; j < LuckyNumbersConst.BoardHeight; j++)
                {
                    nodes[i, j] = new Node();
                }
            }
        }

        public void Clear()
        {
            foreach (var node in nodes)
            {
                node.tile = null;
            }
        }

        public void Init(List<Tile> startTokens)
        {
            for(int i = 0; i < startTokens.Count; i++)
            {
                nodes[i, i].tile = startTokens[i];
            }
        }

        public void ShowBoard()
        {
            var sb = new StringBuilder();
            for(int i = 0;i<LuckyNumbersConst.BoardHeight;i++)
            {
                for(int j = 0;j < LuckyNumbersConst.BoardWidth;j++)
                {
                    if (nodes[i, j].tile == null)
                        sb.Append("[--]");
                    else
                        sb.Append(string.Format("[{0:d2}]", nodes[i, j].tile.val));
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
