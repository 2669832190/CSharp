using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06高阶函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //把函数作为参数使用的函数 叫高阶函数
            Test(helloworld);
        }

        //Action 函数类型
        static void Test(Action f)
        {
            f();
        }

        static void helloworld()
        {
            Console.WriteLine("Hello world");
        }
    }
}
