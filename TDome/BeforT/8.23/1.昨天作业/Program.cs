using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.昨天作业
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.
            /*int xueliang = 1000000000;
            int time = xueliang / (999 * 2);
            int hour = time / (60 * 60);
            int minute = time % (60 * 60) / 60;
            int second = time % (60 * 60) % 60;
            Console.WriteLine($"{hour}小时{minute}分钟{second}秒");*/


            //2.
            /*int i1 = int.Parse(Console.ReadLine());
            if(i1 % 2 ==0)
            {
                Console.WriteLine("偶数");
            }
            else
            {
                Console.WriteLine("奇数");
            }*/

            //3.
            /*int i2 = int.Parse(Console.ReadLine());
            double s = Math.PI * i2 * i2;
            Console.WriteLine(Math.Round(s,2));   //表示按照指定小数位数四舍五入*/

            //4.
            /*double price = double.Parse(Console.ReadLine());
            if(price>=100)
            {
                price *= 0.95;    //price = price * 0.95
            }
            Console.WriteLine(price);*/

            //5.
            /*Console.Write("请输入一个年份：");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{ year}年是闰年");
            }
            else
            {
                Console.WriteLine($"{year}年不是闰年");
            }*/

            //6.
            /*Console.Write("请输入一个时间：");
            int time = int.Parse(Console.ReadLine());
            if(time>0&&time<=24)
            {
                if(time<=6)
                {
                    Console.WriteLine($"现在是凌晨{time}点");
                }
                else if(time<=12)
                {
                    Console.WriteLine($"现在是上午{time}点");
                }
                else if (time <= 18)
                {
                    Console.WriteLine($"现在是下午{time}点");
                }
                else if (time <= 22)
                {
                    Console.WriteLine($"现在是晚上{time}点");
                }
                else
                {
                    Console.WriteLine($"现在是深夜{time}点");
                }
            }
            else
            {
                Console.WriteLine("输入的时间有误！");
            }*/


            //7.
            Console.Write("请输入你的身高：");
            double height = double.Parse(Console.ReadLine());
            Console.Write("请输入你的体重：");
            double weight = double.Parse(Console.ReadLine());

            double BMI = weight / Math.Pow(height,2);

            if(BMI<18.5)
            {
                Console.WriteLine("太瘦了！");
            }
            else if(BMI<24)
            {
                Console.WriteLine("身体倍儿棒！");
            }
            else if(BMI<28)
            {
                Console.WriteLine("有点胖！");
            }
            else
            {
                Console.WriteLine("太胖了！");
            }

            

        }
    }
}
