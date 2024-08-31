using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02递归
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printNumber(3);
            int num = sum(10);
            Console.WriteLine(num);
        }

        //递归 就是在函数的内部 调用他自己
        //如果没有终止条件 一直死循环 直到堆栈溢出
        public static void printNumber(int n)
        {

            //为了避免自己调用自己导致的死循环 需要有一个终止条件
            if(n == 0)
            {
                //return本身的作用是返回一个结果 并且结束整个函数(方法)
                return;
            }

            Console.WriteLine(n);
            printNumber(n - 1); 
            Console.WriteLine(n);
        }

        //输入一个数，计算1-{这个数}的所有数的和
        public static int sum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            //假设传入10
            //10 + 9以前的所有数的总和
            //假设传入9
            //9 + 8以前的所有数的总和
            //...
            int num = n + sum(n - 1);
            return num;
        }
    }
}
