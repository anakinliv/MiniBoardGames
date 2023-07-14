using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRoaster.Game
{
    class BeanSheet
    {
        string name;        //咖啡的名字
        string country;     //国家

        //分数相关
        Dictionary<int, int> score;
        List<int> flavors;

        //设置相关
        Dictionary<int, int> beans;
    }
}
