using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02时间类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime 类，用来操作时间
            //DateTime.Now 获取当前时间
            Console.WriteLine(DateTime.Now);

            //通过DateTime类型的变量，保存当前时间
            DateTime time = DateTime.Now;

            //单独获取某个时间段
            Console.WriteLine("年:" + time.Year);
            Console.WriteLine("月:" + time.Month);
            Console.WriteLine("日:" + time.Day);
            Console.WriteLine("时:" + time.Hour);
            Console.WriteLine("分:" + time.Minute);
            Console.WriteLine("秒:" + time.Second);
            //1秒=1000毫秒
            Console.WriteLine("毫秒:" + time.Millisecond);
            Console.WriteLine("星期几:" + time.DayOfWeek);
            Console.WriteLine("星期几(数字版):" + (int)time.DayOfWeek);

            //格式化输出
            //.ToString() 转换为字符串
            //括号里可以填格式化的时候的特殊字符
            //y 年份
            //M 月份
            //d 日期
            //h 小时
            //m 分钟
            //s 秒
            //f 毫秒
            Console.WriteLine(time.ToString("yyyy-MM-dd hh:mm:ss"));
            Console.WriteLine(time.ToString("yyyy年MM月dd日，hh时mm分ss秒"));

            //共同的特点: 12小时制
            //不同的特点: 位数不同
            //0-9点的时候,hh会以两位显示(如01,02...)   h会以一位显示(如1,2...)
            Console.WriteLine(time.ToString("现在是北京时间:h时"));
            Console.WriteLine(time.ToString("现在是北京时间:hh时"));
            //共同的特点: 24小时制
            Console.WriteLine(time.ToString("现在是北京时间:H时"));
            Console.WriteLine(time.ToString("现在是北京时间:HH时"));

            //毫秒
            Console.WriteLine(time.ToString("现在是:fff"));

            //预设好的格式
            Console.WriteLine(time.ToString("d"));
            Console.WriteLine(time.ToString("D"));
            Console.WriteLine(time.ToString("f"));
            Console.WriteLine(time.ToString("F"));
            Console.WriteLine(time.ToString("g"));
            Console.WriteLine(time.ToString("G"));
            Console.WriteLine(time.ToString("M"));

            //指定时间(年，月，日)
            DateTime MyTime = new DateTime(2024, 9, 20);
            Console.WriteLine(MyTime);
            //指定时间(年，月，日，时，分，秒)
            DateTime MyTime2 = new DateTime(2025, 10, 20, 11, 12, 20);
            Console.WriteLine(MyTime2);

            //时间戳
            Console.WriteLine("时间戳 秒版:" + new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds());
            Console.WriteLine("时间戳 毫秒版:" + new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds());


            while (true)
            {
                //清空控制台信息
                Console.Clear();
                //显示时间
                Console.WriteLine(DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒 dddd"));
                //线程休眠一秒
                //线程休眠 Thread.Sleep(休眠的毫秒数);
                Thread.Sleep(1000);
            }
        }
    }
}
