using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03数组题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.找到数组中最大的数
            int[] arr = { 2, 3, 6, 23, 54, 123, 86, 25, 87 };
            //用来记录最大值
            int max = 0;
            //轮次  i的值  max的值
            //1     0      2
            //2     1      3
            //...
            for (int i = 0; i < arr.Length; i++)
            {
                //当遇到比max要大的值的时候
                if (max < arr[i])
                {
                    //max就等于这个值
                    max = arr[i];
                }
            }
            Console.WriteLine("最大值是:" + max);

            //2.点名器
            string[] strarr = { "孙金明", "周彬", "李耀泽", "刑志迪" };
            Random rand = new Random();
            //随机出的结果是0-3 可以作为索引使用
            int x = rand.Next(strarr.Length);
            Console.WriteLine(strarr[x]);
        }
    }
}
