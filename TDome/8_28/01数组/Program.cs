using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //以前使用的变量，只能保存一个值
            int x = 10;

            /*
             * 数组: 能够一次性的存储多个 同类型的值
             * 声明的方式:
             * 数据类型[] 变量名 = new 数据类型[数组的长度]
             * 
             * 访问数组:
             * 数组的变量名[索引(下标)]   //索引从0开始
             */
            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;

            Console.WriteLine("索引为0的值是:" + arr[0]);
            //索引超出了数组的界限(下标越界) 就会报错
            //arr[3] = 50;

            //数组可以在声明的同时赋值 这样赋值之后 数组的长度也是固定的
            int[] arr2 = { 2, 3, 4, 5, 6 };
            Console.WriteLine(arr2[4]);
            //Console.WriteLine(arr2[5]);

            //声明长度的同时进行赋值
            int[] arr3 = new int[6] { 6, 7, 8, 9, 10, 20 };

            //遍历数组
            //数组变量名.Length 数组的长度
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
