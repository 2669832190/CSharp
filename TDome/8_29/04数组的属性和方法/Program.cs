using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组的属性和方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 4, 5, 6, 7, 8, 9, 10 };
            //数组的长度
            Console.WriteLine(arr.Length);
            //int 32位整型数字 / 8 = 4字节
            //long 64位整型数字 / 8 = 8字节
            Console.WriteLine(arr.LongLength);
            //数组的维度
            Console.WriteLine(arr.Rank);

            //更改数组的长度
            Array.Resize(ref arr, 12);
            Console.WriteLine(arr.Length);
            //清除数组里的内存
            //Array.Clear(数组, 起始索引, 清除长度);
            Array.Clear(arr, 6, 3);
            printArray(arr);
            //数组排序
            Array.Sort(arr);
            printArray(arr);
            //颠倒数组
            Array.Reverse(arr);
            printArray(arr);
            //查找该元素在数组中第一次出现的位置
            //如果找不到，返回-1
            Console.WriteLine(Array.IndexOf(arr, 5));
            //Array.IndexOf(数组, 查找目标, 从哪个索引开始找)
            Console.WriteLine(Array.IndexOf(arr, 5, 10));
            //Array.IndexOf(数组, 查找目标, 从哪个索引开始找, 往后查找3个数)
            Console.WriteLine(Array.IndexOf(arr, 5, 4, 3));
            

        }

        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="arr"></param>
        public static void printArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ",");
                }
            }
            Console.WriteLine("]");
        }
    }
}
