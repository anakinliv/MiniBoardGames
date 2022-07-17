using System;
using LuckyNumbers.Game;

namespace LuckyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LuckyNumbersGame game = new LuckyNumbersGame(1);
            game.Start();
        }
    }
}
