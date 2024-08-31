using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //随机数
            //数据类型 变量名
            //new 创建对象 Random需要被实例化(new)
            Random rnm = new Random();

            //获取一个随机整数
            int rannum = rnm.Next();
            Console.WriteLine("随机到的整数是：" + rannum);


            //获取一个随机的0-1之间的小数
            double d = rnm.NextDouble();
            Console.WriteLine("随机到的小数是：" + d);



            Console.WriteLine("=======================");



            //获取一个随机的0-10之间的小数
            //通过乘一个数，可以把范围变成0-这个数
            d = rnm.NextDouble() * 10;
            Console.WriteLine("d的值是：" + d);

            //获取一个随机的5-6之间的小数
            //通过加一个数，可以把最小值变为这个数
            d = rnm.NextDouble() + 5;
            Console.WriteLine("d的值是：" + d);

            //获取一个随机的150-250的小数
            //* 100 范围变成0-100
            //+ 150 范围变成150-250
            d = rnm.NextDouble() * 100 + 150;
            Console.WriteLine("d的值是：" + d);


            //获取小于10的随机整数   [0,10)
            //填一个数的时候，是从0-这个数之间的非负整数
            rannum = rnm.Next(10);
            Console.WriteLine("随机到的小于10的整数是：" + rannum);

            //获取一个-10到10之间的整数
            //填两个数的时候，是从第一个数-第二个数之间的整数
            int rannum2 = rnm.Next(-10, 10);
            Console.WriteLine("rannum2的值是:" + rannum2);



            Console.WriteLine("=======================");



            //new Random(种子号)
            //默认的种子号是当前的时间戳
            //时间戳：从1970年1月1日到现在的毫秒数
            Random ran1 = new Random(1724721837);
            Random ran2 = new Random(1724721837);

            int i1 = ran1.Next();
            int i2 = ran2.Next();

            Console.WriteLine($"i1的结果是{i1},i2的结果是{i2}");

            //没有使用种子号   默认取当前的时间戳
            //如果运行的快，获取到的时间戳一样，随机出的结果就一样
            Random ran3 = new Random();
            Random ran4 = new Random();

            int i3 = ran3.Next();
            int i4 = ran4.Next();
            Console.WriteLine($"i3的结果是{i3},i4的结果是{i4}");
        }
    }
}
