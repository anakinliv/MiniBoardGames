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
        public List<Tile> pool;
        GamePhase phase;

        private Random rnd;
        private Player currentPlayer;

        public LuckyNumbersGame(int playerCount)
        {
            instance = this;
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
                    bag.PutIn(new Tile(j, i));
                }
            }

            pool = new List<Tile>();
        }

        public void Start()
        {
            foreach(Player player in playerList)
            {
                List<Tile> startTokens = new List<Tile>();
                for(int i = 0; i < 4; i++)
                {
                    startTokens.Add(bag.TakeOut());
                }
                player.InitBoard(startTokens);
            }
            Show();
            //开始
            while(true)
            {
                switch(phase)
                {
                    case GamePhase.None:
                        {
                            phase = GamePhase.TakeClover;
                            currentPlayer = playerList[0];
                            break;
                        }
                    case GamePhase.TakeClover:
                        {
                            if(pool.Count == 0)
                            {
                                phase = GamePhase.PutClover;
                                currentPlayer.Take(bag.TakeOut());
                                Show();
                            }
                            else
                            {
                                Console.WriteLine("1 to take from bag, 2 to take from pool");
                                var key = Console.ReadKey();
                                if(key.KeyChar == '1')
                                {
                                    currentPlayer.Take(bag.TakeOut());
                                    phase = GamePhase.PutClover;
                                    Show();
                                }
                                else if (key.KeyChar == '2')
                                {
                                    int index = int.Parse(Console.ReadLine());
                                    currentPlayer.Take(pool[index]);
                                    pool.RemoveAt(index);
                                    Show();
                                    phase = GamePhase.PutClover;
                                }
                            }
                            break;
                        }
                    case GamePhase.PutClover:
                        {
                            var s = Console.ReadLine();
                            var ss = s.Split(",");
                            currentPlayer.Put(int.Parse(ss[0]), int.Parse(ss[1]));
                            phase = GamePhase.TakeClover;
                            Show();
                            break;
                        }                    
                }
            }
        }

        /// <summary>
        /// 按规则显示棋盘
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Bag has {bag.tokens.Count} left");
            if(pool.Count > 0)
            {
                StringBuilder poolsb = new StringBuilder("pool: ");
                for(int i =0; i < pool.Count;i++)
                {
                    poolsb.Append(String.Format("[{0:d2}]", pool[i].val));
                }
                Console.WriteLine(poolsb.ToString());
            }
            foreach(Player player in playerList)
            {
                player.ShowInfo();
            }
        }

        private static LuckyNumbersGame instance;
        public static LuckyNumbersGame Instance
        {
            get
            {
                return instance;
            }
        }
    }

    enum GamePhase
    {
        None,
        TakeClover,
        PutClover
    }
}
