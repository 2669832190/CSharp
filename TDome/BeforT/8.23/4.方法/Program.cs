using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.方法
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //方法：也叫函数（类的成员）
            //就是把一系列相关的代码组织（封装）到一起，用于执行一些任务的代码块
            //一个方法分为两步：定义（声明）和调用（执行）

            //2.方法的调用
            //在方法名字后边加上()
            //方法中的代码将会在方法被调用时执行，执行完毕后继续回到方法调用的位置，继续执行外部的代码

            Program.Test();
            //如果你在同一个类中定义和调用方法，是不需要显示指定类名来调用的
            Test();

            //如果是变量，定义要在使用的前面
            //如果是方法，定义在前后都可以


            //练习：封装一个方法，输出5次“唱跳Rap篮球”
            Ikun();

        }


        //1.方法的定义
        /*访问修饰符 返回值的数据类型 方法的名字（参数列表）
            {
                这个方法的代码块
            }*/

        //访问修饰符：public(公共的，任何代码都可以访问)
        //返回值的类型：void(没有返回值)

        /*public void Test()
        {

        }*/

        //刚才Test方法声明过之后，你会发现在Main中无法使用，因为Main是一个静态方法
        //上面Test()不是静态的，所以两个方法之间是不互通的，只能把Test()修饰成静态的
        //注意！   并不是说所有的方法都需要static关键字修饰成静态的
        //暂且   在我们当前的方法上添加static关键字（后续详解）

        public static void Test()
        {
            Console.WriteLine("定义的第一个方法");
        }
        public static void Ikun()
        {
            for(int i =0;i<5; i++)
            {
                Console.WriteLine("唱跳Rap篮球");
            }
        }
    }
}
