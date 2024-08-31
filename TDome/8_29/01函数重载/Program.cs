using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01函数重载
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = add(10, 20);
            Console.WriteLine("add的结果是:" + z);

            int number = add(10, 20, 30);
            Console.WriteLine("add的结果是:" + number);

            double d = add(25.5, 32.6);
            Console.WriteLine("add的结果是:" + d);

            add("这是个字符串");
        }

        /*
         * 重载就是有多个函数 名字必须相同
         * 参数类型不同
         * 参数数量不同
         * 
         * 重载与返回值类型无关
         */

        public static int add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("调用了两个int参数的add方法");
            return z;
        }

        public static int add(int x, int y, int z)
        {
            int number = x + y + z;
            Console.WriteLine("调用了三个int参数的add方法");
            return number;
        }

        public static double add(double x, double y)
        {
            double z = x + y;
            Console.WriteLine("调用了两个double参数的add方法");
            return z;
        }

        public static void add(string x)
        {
            Console.WriteLine("调用了字符串参数的add方法，输出字符串长度");
            Console.WriteLine(x.Length);
        }
    }
}
