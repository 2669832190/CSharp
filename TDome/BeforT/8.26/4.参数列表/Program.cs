using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.参数列表
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //一个方法除了可以接收固定个数的参数外，还能接收未知数量的参数
            Sum();
            Sum(1,2,3);
            Sum(7, 8, 9, 10, 11, 12);
            Console.WriteLine(Sum(1, 2, 3));  //6
            Console.WriteLine(Sum(7, 8, 9, 10, 11, 12));   //57

            //定义一个方法，传递一堆未知数量的参数，找出其中的最大值
            Console.WriteLine(FindMax(4,65,20,59,87,45,31,20));


            Test(1, "kunkun", true, "a", "b", "c", "d");
        }

        //格式：
        //(params 数据类型[] 参数的名字)
        public static int Sum(params int[] nums)
        {
            Console.WriteLine($"方法的参数列表是：{nums}");   //System.Int32[]    int类型的参数列表
            Console.WriteLine($"参数的个数是：{nums.Length}");
            //想要查看具体的某一个，   nums[0]   nums[1].....

            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = nums[i] + result;
            }
            return result;
        }

        public static int FindMax(params int[] nums)
        {
            int max = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        //方法的参数可以同时接收普通参数和params参数
        //params必须是参数的最后一个
        /*public static void Test(params int[] nums,int a,bool b,)
        {

        }*/

        public static void Test(int a,string b, bool c,params string[] strs)
        {
            for(int i = 0;i<strs.Length;i++)
            {
                Console.WriteLine(strs[i]);
            }
        }
    }
}
