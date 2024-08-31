using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.引用传参
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //方法传递参数的方案：
            //按值传递：方法的默认传递方式，这种方式会在方法执行时声明了一个新变量来接受一个参数
            //实参的值会复制给这个新变量，传递的数据类型不同会出现不同的效果
            //当传递一个值类型的时，方法内部修改形参，不会影响到外部；当传递一个引用类型时，方法内部修改形参，会影响外部

            //按引用传递参数：传递参数时加上ref
            //当传递值类型时，需要在方法内部修改传递过来的变量时，就需要用到按引用传递了

            int x = 2;
            Test(x);
            Console.WriteLine(x);  //2

            Test1(ref x);    //接收的时候也必须加上ref
            Console.WriteLine(x); //10

            //按引用传递只能传递变量，不能直接传值
            Test(1);
            //Test1(ref 1);


            //定义一个方法，交换a和b的值
            int a = 1, b = 2;
            Swap(a,b);
            Console.WriteLine($"{a},{b}");
            Swap1(ref a, ref b);
            Console.WriteLine($"{a},{b}");

            //方法内部修改形参，外部是否受到影响？
            //1.先看传递的参数是什么数据类型，值类型，不受影响；引用类型，受影响
            //2.值类型，如果使用了ref按引用传递，内部形参的修改，影响外部

        }

        public static void Test(int a)
        {
            a = 10;
        }
        public static void Test1(ref int a)
        {
            a = 10;
        }
        public static void Swap(int a ,int b )
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Swap1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
