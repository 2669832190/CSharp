using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03交错数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            //复习二维数组
            int[,] arr = new int[3, 4]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 }
            };
            //访问元素
            arr[1, 2] = 20;
            Console.WriteLine(arr[1, 2]);
            //遍历
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            */
            #endregion


            int[] ints = { 5, 6, 7, 8, 9 };

            //多维数组 每一行的长度必须相同
            //交错数组(交叉数组) 相当于数组的数组
            int[][] arr1 = new int[][]
            {
                //里面可以存放一维数组
                new int[]{1,2,3,4},
                ints
            };
            //访问元素
            Console.WriteLine(arr1[0][2]);

            //arr1里包含了几个一维数组
            Console.WriteLine(arr1.Length);
            //arr1[0] arr1里第一个数组的长度
            Console.WriteLine(arr1[0].Length);
            //arr1[1] arr1里第二个数组的长度
            Console.WriteLine(arr1[1].Length);

            //遍历数组
            //arr1.Length arr1包含了几个数组
            for (int i = 0; i < arr1.Length; i++)
            {
                //arr1[i].Length 第i个数组的长度
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j]);
                }
                Console.WriteLine();
            }

            //三层交叉数组
            int[][][] arr3D = new int[][][]
            {
                new int[][]
                {
                    new int[]{1,2,3},
                    new int[]{4,5,6,7}
                },
                new int[][]
                {
                    new int[]{12,13,14,15,16},
                    new int[]{10,11}
                }
            };
            //遍历
            for (int i = 0; i < arr3D.Length; i++)
            {
                for (int j = 0; j < arr3D[i].Length; j++)
                {
                    for (int k = 0; k < arr3D[i][j].Length; k++)
                    {
                        Console.Write(arr3D[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
