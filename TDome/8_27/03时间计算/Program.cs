using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03时间计算
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //获取到当前时间
            DateTime time = DateTime.Now;

            //通过调用对应的增加方法，增加对应的时间
            time = time.AddYears(1);
            time = time.AddMonths(1);
            time = time.AddDays(1);
            time = time.AddHours(1);
            time = time.AddMinutes(1);
            time = time.AddSeconds(1);
            Console.WriteLine("计算后的时间是:" + time);

            //可以通过增加负数，减少对应的时间
            time = time.AddDays(-1);
            Console.WriteLine("前一天是:" + time);

            //2026年比2025年大
            //因为内部保存的是时间戳
            Console.WriteLine(time > new DateTime(2026, 1, 1));
            Console.WriteLine(time > new DateTime(2008, 5, 12));

            //时间间隔
            TimeSpan t = time - new DateTime(2008, 5, 12);
            Console.WriteLine("这两个时间相差了" + t.TotalDays + "天");
            Console.WriteLine("这两个时间相差了" + t.TotalDays / 365 + "年");
            Console.WriteLine("这两个时间相差了" + t.TotalHours + "时");
            Console.WriteLine("这两个时间相差了" + t.TotalMinutes + "分");
        }
    }
}
