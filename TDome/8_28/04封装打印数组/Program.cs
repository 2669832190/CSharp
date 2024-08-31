using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04封装打印数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            printArray(arr);
        }

        //这个方法的效果，是传入一个int数组，在控制台打印出这样的格式: [1,2,3,4,5,6]
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

        #region 方法复习

        /*函数(方法) 结构:
         * [访问修饰符] [静态修饰符] 返回值类型 方法名(参数类型 参数名...)
         * {
         *      代码块;
         * }
         * 
         * 访问修饰符 略(忘记的去看结构体)
         * 静态修饰符 变成一个静态方法 1.创建的早,程序开始运行时就创建了这个方法 2.(后续详解)
         * 返回值类型 当这个方法运行完以后,需要返回出去的最终结果
        */
        public static void test()
        {
            Console.WriteLine("调用了test方法");
        }

        //两数相加的和
        public static int add(int x, int y)
        {
            int z = x + y;
            return z;
        }
        #endregion
    }
}
