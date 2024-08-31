using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.方法的返回值
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();


            //通过变量接收方法的返回值，变量的类型要跟方法返回值的类型一致
            string s1 = Test();
            Console.WriteLine(s1);    //计算的结果


            //定义一个方法    传入两个参数    返回他俩的和
            int sum = Sum(100,200);
            Console.WriteLine(sum);   //300

        }

        //这种方法仅仅为了输出，没有其他的需求，他不需要返回给程序一些值
        public static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

        //有些方法的功能以计算为目的，一般需要这个方法内部的代码块执行结束后获取到对应的结果
        //需要在定义方法时候指定返回值的类型
        public static string Test()
        {
            //使用return返回对应的内容   返回的类型必须跟你标注的一致
            return "计算的结果";
        }


        public static int Sum(int a, int b)
        {
            /*int c = a + b;
            return c;*/
            return a + b;

            //return 不仅可以返回数据，还可以用于终止方法的执行
            Console.WriteLine(a +b);
        }
    }
}
