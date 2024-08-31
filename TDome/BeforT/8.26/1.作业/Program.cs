using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.作业
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //9.
            /*int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    //Console.WriteLine(i);
                    count += 1;    //count = count+1;
                }
            }
            Console.WriteLine(count);*/


            //10.
            /*int count = 0;
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                    sum = sum + i;

                }
                if (count == 5)
                {
                    Console.WriteLine($"这五个数的和为：{sum}");
                    sum = count = 0;
                }
            }*/

            //11.
            /*for (int i = 100; i < 1000; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;

                double sum = Math.Pow(bai, 3) + Math.Pow(shi, 3) + Math.Pow(ge, 3);

                if (sum == i)
                {
                    Console.WriteLine($"{i}是一个水仙花数");
                }
            }*/

            //12.
            /*for (int i = 1; i <= 9; i++)
            {
                //每一行有多少列？ 1行1列   2行2列......
                for(int j=1;j<=i;j++)
                {
                    Console.Write($"{j} * {i} = {j*i} ");
                }
                Console.WriteLine();
            }*/

            //13.
            /*for (int i = 1; i < 30; i++)  //铅笔
            {
                for (int j = 1; j <= 60; j++)   //橡皮
                {
                    for (int k = 1; k < 34; k++)   //笔记本
                    {
                        double sum = 1.7 * i + 0.5 * j + 1.5 * k;
                        if (sum <= 50 && 50 - sum <= 0.5 && i + j + k == 60)
                        {
                            Console.WriteLine($"铅笔{i},橡皮{j},笔记本{k}");
                        }
                    }
                }
            }*/

            //14.
            /*for(int i =0;i<14;i++)
            {
                for(int j =0;j<10;j++)
                {
                    if (i + j == 14&& i*2+j*4==38)
                    {
                        Console.WriteLine($"鸡有{i}只，兔有{j}只");
                    }
                }
            }*/


            //15.
            /*for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j < 34; j++)
                {
                    int k = 100 - i - j;
                    if (i * 5 + j * 3 + k / 3 == 100 && i + j + k == 100 && k % 3 == 0)
                    {
                        Console.WriteLine($"公鸡{i}只，母鸡{j}只，小鸡{k}只");
                    }
                }
            }*/


            //16.
            /*//goto方案
            *//*int count = 0;
        login:
            Console.Write($"请输入用户名：");
            string UserName = Console.ReadLine();
            Console.Write($"请输入密码：");
            string Password = Console.ReadLine();

            if (UserName == "admin" && Password == "123")
            {
                Console.WriteLine("登录成功！");
            }
            else
            {
                count++;
                if(count ==3)
                {
                    Console.WriteLine("你已经输错三次，明天再来试试吧~");
                    goto aaa;
                }
                Console.WriteLine($"账号或密码错误，请重新输入！剩余次数{3 - count}");
                goto login;
            }
            aaa:
            Console.ReadLine();*/


            //for方案
            /*for (int i =0;i<3;i++)
            {
                Console.Write($"请输入用户名：");
                string UserName = Console.ReadLine();
                Console.Write($"请输入密码：");
                string Password = Console.ReadLine();

                if (UserName == "admin" && Password == "123")
                {
                    Console.WriteLine("登录成功！");
                    break;
                }

                if(i ==2)
                {
                    Console.WriteLine("你已经输错三次，明天再来试试吧~");
                    break;
                }

                Console.WriteLine($"账号或密码错误，请重新输入！剩余次数{3 - i-1}");
            }*/


            //while方案
            int count = 0;
            while (true)
            {
                Console.Write($"请输入用户名：");
                string UserName = Console.ReadLine();
                Console.Write($"请输入密码：");
                string Password = Console.ReadLine();

                if (UserName == "admin" && Password == "123")
                {
                    Console.WriteLine("登录成功！");
                    break;
                }

                count++;

                if (count == 3)
                {
                    Console.WriteLine("你已经输错三次，明天再来试试吧~");
                    break;
                }

                Console.WriteLine($"账号或密码错误，请重新输入！剩余次数{3 - count}");
            }





        }
    }
}
