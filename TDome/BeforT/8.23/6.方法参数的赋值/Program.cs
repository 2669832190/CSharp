using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.方法参数的赋值
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            Test(i1);
            Console.WriteLine(i1);  //2
            //值类型   方法调用时传递的是变量的值，而不是变量本身
            //上面的写法这样理解：   int z = 2;    int x = z;   x=20;   z=?
            int x = 3;
            Test(x);
            Console.WriteLine(x);   //3

            //----------------------------------------------------------------------------------------

            People p1 = new People();
            p1.name = "张三";
            Test1(p1);
            Console.WriteLine(p1.name);   //变身之后的张三
            //相当于这样理解：
            //People p1 = new People();
            //p1.name = "张三";
            //People people = p1;
            //people.name = "变身之后的xxx";
            //p1.name=?


        }

        public static void Test(int x)
        {
            Console.WriteLine($"传入的参数为：{x}");
            //想通过方法内部形参的修改修改传递过来的实参的值
            x = 20;
        }
        public static void Test1(People people)
        {
            Console.WriteLine($"名字是：{people.name}");
            //想通过方法内部形参的修改修改传递过来的实参的值
            people.name = "变身之后的" + people.name;
        }
    }

    class People
    {
        public string name;
    }
}
