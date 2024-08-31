using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //T1();
            //T2();
            //T3();
            //T4();
            T5();
        }


        //1. 创建一个int数组（内容不限），从数组中，找到最小的值
        static void T1()
        {
            int[] arr = { 4, 5, 2, 3, 6, 7 };
            //用来存放最小的值
            int min = arr[0];
            //从1号索引开始比较
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("最小的值是:" + min);
        }

        //2. 创建一个int数组（内容不限），计算数组中所有数的和
        static void T2()
        {
            int[] arr = { 4, 5, 2, 3, 6, 7 };
            //用于保存所有数的和
            int number = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                number += arr[i];
            }
            Console.WriteLine("所有数的和是:" + number);
        }

        /*3. 点名器，用字符串数组保存多个同学的名字
            在控制台按下任意按键，随机挑出一个同学
            （点过的同学不能重复点到）
        */
        static void T3()
        {
            //保存所有同学的名字
            string[] arr = { "张三", "李四", "王五", "赵六" };

            /*
            //获取一行内容
            Console.ReadLine();
            //获取一个字符
            Console.Read();
            //获取下一个键    INS(insert) DEL(delete)
            Console.ReadKey();
            */

            while (true)
            {
                Console.WriteLine("按下任意键挑选一个同学");
                //按下任意键
                Console.ReadKey();
            rollCall:
                Random ran = new Random();
                //随机一个索引 [0,3]
                int index = ran.Next(arr.Length);

                //判断是不是已经为空了
                if (arr[index] != null)
                {
                    Console.WriteLine("点到的同学是:" + arr[index]);
                    arr[index] = null;
                }
                else
                {
                    goto rollCall;
                }

            }
        }

        /*4. 创建一个5行的二维数组（内容不限）
            4_1. 交换第二行和第四行的内容
            4_2. 输出这个数组里的所有的值 
         */
        static void T4()
        {
            int[,] arr = new int[5, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
                {10,11,12 },
                {13,14,15 }
            };
            //循环{数组中的列}次
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                //交换变量 语法糖
                //(变量A,变量B) = (变量B,变量A);
                (arr[1, i], arr[3, i]) = (arr[3, i], arr[1, i]);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }

        //5. 创建一个数组，输入一个数字，输出这个数字在数组中第一次出现的位置
        static void T5()
        {
            int[] arr = { 3, 4, 5, 6, 7, 8, 9, 12, 34, 67 };
            Console.WriteLine("请输入一个数字");
            //输入一个数字
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("第一次出现的索引是:" + i);
                    break;
                }
            }
        }
    }
}
