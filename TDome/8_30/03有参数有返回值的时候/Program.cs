using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03有参数有返回值的时候
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(20, Area);
        }

        //需求:传入一个边长，再传入一个计算面积的函数
        //然后使用这个函数计算面积

        //Func 当传入的函数有返回值的时候,Action就不行了
        //<>里面 先填入参数类型，最后填入返回值类型
        static void Test(int x, Func<int,int> HanShu)
        {
            int a = HanShu(x);
            Console.WriteLine("计算完成，面积是:" + a);
        }

        /// <summary>
        /// 计算正方形的面积
        /// </summary>
        /// <param name="x">正方形的边长</param>
        /// <returns>正方形的面积</returns>
        static int Area(int x)
        {
            return x * x;
        }
    }
}
