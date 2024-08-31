using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02有参数的高阶函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test(Area);
            Test(5,10,Area);
        }

        //当我们传递进来的函数有参数时 ， 需要通过Action后面的<>里 约定一下
        static void Test(Action<int,int> F)
        {
            F(10,20);
        }

        /// <summary>
        /// 计算面积的函数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Area(int x, int y)
        {
            Console.WriteLine("面积是:" + (x * y));
        }

        static void Test(int x,int y,Action<int,int> F)
        {
            F(x, y);
        }
    }
}
