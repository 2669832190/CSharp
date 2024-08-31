using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.循环控制break_continue_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //break
            //主要用在循环中，在switch中也有用到（表示中断）
            //跳出循环、立即停止循环
            //一般用break来控制循环的次数达到性能优化的目的
            //如：要寻找某些数字中满足条件的第一个

            //找到925-1226中的第一个能被3和5整除的数
            for (int i = 925; i <= 1226; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"第一个能被3和5整除的数是{i}");
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);   //0 1 2 3 4
            }


            //continue    继续    跳过当前这一次循环，继续往后执行
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);   //0 1 2 3 4 6 7 8 9
            }


            //输入一个数，判断1-10之间的素数（1 2 3 5 7）和合数（4 6 8 9 10）
            int num = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int i = 1; i <= 10; i++)
            {
                if (i == 1 || num == i)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (num % i == 0)//1.  i==1的情况没有必要参与num%i的计算，因为所有的数都满足
                {                //    所以一开始循环i=1的时候直接跳出这一次循环，让i++;
                    flag = true; //2.  从i=2开始，相当于你要进行num%i的计算了，那如果某一次满足num%i==0了；     
                    break;       //    就证明有除了1和本身之外的因数，所以直接break结束
                }                //3.  随着循环次数i的增加，一直都不能满足num%i==0；直到num=i的情况你也得跳过，
            }                    //    因为num=i的时候满足num%i==0；那么在num =i 之后i再增加，num%i就不会再是0了，直到循环结束
            if (flag)            //4.  最终  素数始终没有num%i==0过，那里边的语句也就没有执行过，flag一直都没有变成true
            {                    //          合数在某一次满足num%i==0的时候就已经结束循环了。
                Console.WriteLine("合数");
            }
            else
            {
                Console.WriteLine("素数");
            }




            //goto
            //1.在你需要的位置，做一个标记，名字自定义
            aaa:
            Console.Write("请输入性别：");
            string sex = Console.ReadLine();
            if(sex=="男")
            {
                Console.WriteLine("爷们儿！");
            }else if(sex =="女")
            {
                Console.WriteLine("姑娘！");
            }
            else
            {
                Console.WriteLine("what?请重新输入！！！");
                goto aaa;
            }


            //1-100之间的偶数和
            int sum = 0;
            int num1 = 0;

            abc:
            num1 += 1;
            if(num1%2==0)
            {
                sum += num1;
            }
            if(num1<101)
            {
                goto abc;
            }
            Console.WriteLine(sum);



        }
    }
}
