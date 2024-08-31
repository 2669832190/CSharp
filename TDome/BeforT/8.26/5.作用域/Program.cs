using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.作用域
{
    internal class Program
    {
        static void Main(string[] args)
        {//从这开始，能访问a

            //
            int a = 1;
            Console.WriteLine(a);


            Test();

        }//到这结束，不能访问a

        public static void Test()
        {
            //Console.WriteLine(a);
            //报错，因为在Test方法中不能访问到Main方法内部作用域的变量

            //在不同的作用域中可以声明相同的变量名的
            int a = 2;
            Console.WriteLine(a);
        }

        public static void Test2()
        {
            if(true)
            {
                int a = 5;
            }
            //Console.WriteLine(a);   //不能访问
        }

        public static void Test3()
        {
            for(int i =0;i<5;i++)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);   //不能访问
        }

        public static void Test4()
        {
            {
                int a = 3;
            }
            //Console.WriteLine(a);   //不能访问
        }

        public static void Test5()
        {
            {
                int a = 3;
            }
            {
                int a = 5;
            }
            //这两个a属于不同的作用域，所以表示两个不同的a
        }

        //看花括号   一个花括号就是一个作用域
        //作用域嵌套   里面的能访问外面的
    }
}
