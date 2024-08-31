using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04结构体
{
    /*
     为什么要有结构体？
     1.方便，一个结构体变量里面能保存多条信息
     2.可以把一套相关的信息保存到一个结构体里
     */


    //访问修饰符 struct

    //访问修饰符:
    //public 公共的，公开的 任何地方都可以访问
    //private 私有的 只有自己可以访问
    //internal 内部的 当前命名空间下可以访问
    //protected 受限的 自己和派生类可以访问

    //字段 一般以_开头
    public struct Student
    {
        //姓名
        public string _name;
        //性别
        public string _sex;
        //年龄
        public int _age;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //创建一个结构体的变量
            //用我们刚才创建的结构体类型 作为数据类型
            Student stu1;
            stu1._name = "奥德彪";
            stu1._sex = "男";
            stu1._age = 18;

            Console.WriteLine("stu1的名字是:" + stu1._name);
            Console.WriteLine("stu1的性别是:" + stu1._sex);
            Console.WriteLine("stu1的年龄是:" + stu1._age);

        }
    }
}
