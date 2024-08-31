using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.变量和常量
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //变量：
            //变量就是对程序中某个数据的引用，比如x表示一个数值，name表示一个名字


            //为什么要使用变量？
            //1.我们可以用一个简单的单词表示很长的一段字符，比如用字母a表示身份证号
            //2.我们可是用一个变量，在不同的位置表示不同的值

            //变量在程序中只是一个存储数据的名字，每一个变量都有一个指定的数据类型，类型决定了所占用内存空间的大小


            //变量的声明（定义）
            //格式：  数据类型+变量的名字
            //常用的数据类型：int(整数类型)、double(浮点数)、bool(布尔类型 trur/false)、string(字符串)


            //见名知意
            int age;
            double weight;
            string name;


            //变量命名规范
            //1.只能包含字母、数字、_、@(注意：数字不能当开头，@只能当开头)
            int a;
            //int 1;
            int a1;
            int a_1;
            //int b@;
            //2.不能用内置的类或者关键字
            //int Console;
            //Console.WriteLine();
            //int int;
            //int class;
            //3.不能重复声明一个变量
            //int a;
            //4.大小写敏感
            int C;
            int c;

            //驼峰命名法
            //UserName     userName

            //变量的赋值
            //   =    赋值运算符    把=右边的值  赋值  给左边的变量
            int i1;
            i1 = 10;   //让变量i1存储数据10，后边不改变的情况下，i1表示10
            //如果变量再次被赋值，那么它会将原来的值丢弃掉，重新保存新的值
            i1 = 20;
            Console.WriteLine(i1);//没有双引号  表示变量

            Console.WriteLine("i1");  //有双引号，表示字符串

            //声明变量的同时，直接给变量赋值（变量的初始化）
            int i2 = 10;

            //同时声明多个变量
            int i3, i4, i5;
            //同时声明多个变量并赋值
            int i6 = 10, i7 = 20, i8 = 30;


            //变量先声明，再赋值，再使用
            //Console.WriteLine(i10);
            int i10;
            //Console.WriteLine(i10);
            i10 = 100;
            Console.WriteLine(i10);

            //常量
            //常量和变量相似，唯一不同常量的值在程序的编译阶段就已经确定了，一旦声明好，无法修改
            const int i11 = 10;
            //i11=11;


            //1.
            string name1 = "坤坤";
            int age1 = 18;
            string time = "两年半";
            Console.WriteLine("他的名字是：" + name1 + ",人家今年" + age1 + "岁" + "练习时长" + time);

            //2.
            //{0}{1}{2} 占位符
            Console.WriteLine("他的名字是：{0}，人家今年{1}岁~，练习时长{2}", name1, age1, time);
        }
    }
}
