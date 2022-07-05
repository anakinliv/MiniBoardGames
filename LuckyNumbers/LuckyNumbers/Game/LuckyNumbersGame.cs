using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumbers.Game
{
    internal class LuckyNumbersGame
    {
        List<Player> playerList;
        int playerCount;
        Bag bag;

        private Random rnd;

        public LuckyNumbersGame(int playerCount)
        {
            //准备随机数
            rnd = new Random();

            //准备玩家
            this.playerCount = playerCount;
            playerList = new List<Player>();
            for(int i = 0; i < playerCount; i++)
            {
                playerList.Add(new Player());
            }

            //准备数字Token并放入盲抽袋
            bag = new Bag(rnd);
            for(int i = 0; i < playerCount; i++)
            {
                for(int j = 1; j <= LuckyNumbersConst.TokenNumber; j++)
                {
                    bag.PutIn(new Token(j, i));
                }
            }
        }

        public void Start()
        {
            foreach(Player player in playerList)
            {
                List<Token> startTokens = new List<Token>();
                for(int i = 0; i < 4; i++)
                {
                    startTokens.Add(bag.TakeOut());
                }
                player.InitBoard(startTokens);
            }
        }
    }
}
