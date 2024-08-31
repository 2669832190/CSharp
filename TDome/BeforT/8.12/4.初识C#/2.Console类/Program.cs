using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Console类
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console   C#中已经封装好的一个类

            Console.WriteLine("Hello World!");

            //方法：

            //输出到控制台
            //输出后会换行
            Console.WriteLine("Hello World!");

            //输出之后不会换行
            Console.Write("大米套餐");
            Console.Write("兰州拉面");
            Console.WriteLine();


            //从控制台输入
            //获取输入的一行文本，返回给程序一个字符串（输入之后按下回车键才算输入完成）
            Console.ReadLine();
            Console.WriteLine("用户输入了一行文本，并且按下了回车键");

            string name = Console.ReadLine();
            Console.WriteLine("我的名字是："+name);


            //获取按下的一个按键
            Console.ReadKey();
            Console.WriteLine("用户按下了一个键");



            //通过控制台播放扬声器的声音
            //Console.Beep();

            //可以控制播放的频率和持续的时间
            //参数一：频率  37-32767之间
            //参数二：持续的时间  以毫秒为单位
            //Console.Beep(3000,3000);


            //清除控制台内容（上边）
            Console.Clear();


            //Console.ReadLine();
            //上面的这些操作，后边都带了一个小括号，我们将这些称之为方法的调用。



            //属性
            Console.WriteLine("获取控制台的背景颜色");
            //获取属性
            Console.WriteLine(Console.BackgroundColor);
            //修改属性
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("修改过的新的背景颜色："+ Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Black;

            //字体颜色
            Console.WriteLine("获取控制台的默认字体颜色");
            Console.WriteLine(Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("修改过的新的字体颜色：" + Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
