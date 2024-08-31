using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.输出传递参数
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //输出传递参数
            //return 用于返回方法执行的结果  但是它只能返回一个数据；  如果需要同时返回多个数据到方法调用的地方 ，就可以使用out输出传递的参数

            //out的用法和ref是一样

            int a = 1, b = 2, c = 3;
            Test1(ref a, ref b, ref c);
            Console.WriteLine($"{a},{b},{c}");

            int d, e;
            Test2(out d, out e);
            Console.WriteLine($"{d},{e}");

            //out 和  ref区别
            //out 传递参数时候不用进行初始化，ref必须初始化
            //out 传递的参数  在方法中 必须先赋值才能使用
            //ref传递的参数可以在方法中获取值   out只能从方法中返回值（out不能传递进去数据）


            //ref主要目的是为了传如数据，所以传入之前必须初始化
            //out主要目的是为了传出数据，因此传入之前可以不用初始化，方法中去赋值
        }
        public static void Test1(ref int x,ref int y,ref int z)
        {
            Console.WriteLine($"Test1方法中x:{x},y:{y}");
            x = 20;
            y = 30;
            z = z + 10;
        }
        public static void Test2(out int x,out int y,out int z)
        {
            Console.WriteLine($"Test2方法中x:{x},y:{y}");
            x = 20;
            y = 30;
            z = z + 10;
        }
    }
}
