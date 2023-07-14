using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoffeeRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取配置

        }

        void ReadConfig()
        {
            string filePath = @"..\..\Config\coffee.txt"; // 相对路径

            // 获取配置文件的完整路径
            string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);

            // 读取纯文本文件
            using (var reader = new StreamReader(configFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // 解析文本行为CoffeeBean对象
                    // var coffeeBean = ParseCoffeeBean(line);

                    // 在这里使用coffeeBean进行游戏逻辑操作
                }
            }

            Console.WriteLine("感谢游玩咖啡烘培师游戏！");
            Console.ReadLine();
        }
    }
}
