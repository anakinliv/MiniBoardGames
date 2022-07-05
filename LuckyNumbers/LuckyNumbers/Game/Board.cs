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
                node.token = null;
            }
        }

        public void Init()
        {
            for(int i = 0; i < LuckyNumbersConst.BoardWidth ; i++)
            {
                for(int j = 0; j < LuckyNumbersConst.BoardHeight ; j++)
                {
                    var node = new Node();
                    
                }
            }
        }
    }
}
