using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习高阶函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test(Print);

            Test(3, Print);
        }

        #region
        //把方法(函数)作为参数的方法(函数) 高阶函数
        static void Test(Action F)
        {
            F();
        }

        static void Print()
        {
            Console.WriteLine("Hello");
        }
        #endregion

        //x 表示调用F的次数
        static void Test(int x,Action F)
        {
            for(int i = 0;i< x; i++)
            {
                F();
            }
        }
    }
}
