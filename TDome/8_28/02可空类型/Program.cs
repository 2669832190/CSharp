using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02可空类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //可空类型 就是让 基础类型的值能够保存null
            //声明时 通过 数据类型? 声明为可空类型
            //可空类型 默认值是null
            int? x;
            x = null;

            //数组的空值
            int?[] arr = { 1, 2, 3, 4, null };
            Console.WriteLine(arr.Length);
            //啥都没有
            Console.WriteLine(arr[4]);
            //判断是否为空
            Console.WriteLine(arr[4] == null);

            //?? 先判断它左边的值是否为null
            //如果为空,b赋值为??右边的值
            //如果不为空,b赋值为左边的值
            int b = arr[4] ?? 20;
            Console.WriteLine(b);   //20
            b = arr[3] ?? 20;
            Console.WriteLine(b);   //4
        }
    }
}
