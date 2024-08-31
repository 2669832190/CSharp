using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 8, 3, 7, 2, 5, 1, 9 };
            //[9,8,7,6,5,4,3,2,1]
            //冒泡排序法(一共9个数)
            //6,8,4,7,3,5,2,9,1     第一轮 进行了8次比较 i=0 j循环8次
            //8,6,7,4,5,3,9,2       第二轮 进行了7次比较 i=1 j循环7次
            //8,7,6,5,4,9,3         第三轮 进行了6次比较 ...
            //8,7,6,5,9,4           第四轮 进行了5次比较
            //8,7,6,9,5             第五轮 进行了4次比较
            //8,7,9,6               第六轮 进行了3次比较
            //8,9,7                 第七轮 进行了2次比较
            //9,8                   第八轮 进行了1次比较

            //9,8,7,6,5,4,3,2,1
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //当前索引数 小于 索引+1的数
                    if (arr[j] < arr[j + 1])
                    {
                        //交换变量 语法糖
                        //(arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
