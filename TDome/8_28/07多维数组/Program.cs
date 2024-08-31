using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07多维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //一维数组
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            //二维数组
            int[,] ints = new int[3, 4]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 }
            };

            Console.WriteLine(ints[0, 1]);
            //对于多维数组 Length依然访问的是总长度
            Console.WriteLine(ints.Length);
            //.GetLength(指定一个维度)
            //.GetLength(0) 第一个维度(有多少行)
            Console.WriteLine(ints.GetLength(0));
            //.GetLength(1) 第二个维度(有多少列)
            Console.WriteLine(ints.GetLength(1));

            //外层循环 负责行
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                //内层循环 负责列
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            //三维数组
            int[,,] arr3D = new int[2, 3, 4]
            {
                {
                    {1,2,3,4},
                    {5,6,7,8},
                    {9,10,11,12}
                },
                {
                    {13,14,15,16},
                    {17,18,19,20},
                    {21,22,23,24}
                }
            };
            foreach (int i in arr3D)
            {
                Console.Write(i + " ");
            }
        }
    }
}
