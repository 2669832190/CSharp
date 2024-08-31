using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        Area(10);
                        Area(20, 30);
            */

            /*
                        int x = GetLength(new int[] { 1, 2, 3, 4 });
                        Console.WriteLine("数组长度是:" + x);
                        GetLength(new string[] { "abc", "123", "789" });
            */

            //第三题
            //PrintInt(1234567);

            //第四题
            //PalindromeString("上海自来水来自海上");
            //PalindromeString("上海自来水");

            //第五题
            //Lookup(5, new int[] { 1, 2, 3, 4, 5, 6, 8, 7, 6, 5, 4, 3 });
        }

        #region 第一题
        static int Area(int w, int h)
        {
            int area = w * h;
            return area;
        }

        static int Area(int x)
        {
            return x * x;
        }
        #endregion

        #region 第二题
        static int GetLength(int[] arr)
        {
            return arr.Length;
        }
        static void GetLength(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        #endregion

        #region 第三题
        static void PrintInt(int x)
        {
            //终止条件 如果小于10 直接输出个位
            if (x < 10)
            {
                Console.Write(x);
                return;
            }

            //输出个位
            Console.Write(x % 10);
            //把十位以上的数传递给递归
            PrintInt(x / 10);
        }
        #endregion

        #region 第四题
        static void PalindromeString(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    Console.WriteLine("不是回文字符串");
                    return;
                }
            }
            Console.WriteLine("是回文字符串");
        }
        #endregion

        #region 第五题
        /// <summary>
        /// 查找值在数组中第二次出现的位置
        /// </summary>
        static void Lookup(int x, int[] arr)
        {
            //记录已经出现的次数
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //找到了这个数
                if (arr[i] == x)
                {
                    //第一次找到的时候 number+1  number最终等于1
                    //第二次找到的时候 number+1  number最终等于2
                    number++;
                    if (number == 2)
                    {
                        Console.WriteLine("第二次出现的索引是:" + i);
                    }
                }
            }
        }
        #endregion
    }
}
