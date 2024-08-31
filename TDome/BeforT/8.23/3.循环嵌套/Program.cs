using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.循环嵌套
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //外层循环
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("---------------------");
                //内层循环    外层循环每执行一次，内层循环执行5次
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"内部循环i:{i},j:{j}");
                }
            }


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"i的值{i}");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"j的值{j}");
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine($"k的值{k}");
                    }
                }
            }


            //循环嵌套中使用break和continue
            for(int i =0;i<3;i++)
            {
                Console.WriteLine("---------------------");
                for (int j =0;j<3;j++)
                {
                    if(i==1)
                    {
                        //break;
                        continue;
                    }
                    Console.WriteLine($"内部循环i:{i},j:{j}");
                }
               
            }
        }
    }
}
