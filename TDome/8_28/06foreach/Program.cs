using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6, 7 };
            
            //基本结构:
            //foreach(数组里面存放的类型 变量名 in 需要遍历的数组)

            //和for相比
            //1.写起来简单 只有foreach(类型 变量名 in 遍历谁)
            //2.没有索引 改变值比较麻烦 无法控制循环次数
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //字符串遍历
            string[] strarr = { "张三", "李四", "王五", "赵六" };
            foreach (string str in strarr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
