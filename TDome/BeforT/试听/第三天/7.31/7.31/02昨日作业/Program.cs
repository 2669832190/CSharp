namespace _02昨日作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ABCDE 五个等级  年底考核 你现在的工资是 1w  ；
            //A + 500   b + 200  c + 0  d - 1000  e - 3000
            //输入一个等级 返回 明年的月薪(if  else if  else)


            //假设是A

            //if (？ == A)
            //{

            //}else if (? == B)
            //{

            //}
            //Console.WriteLine( 1 == 2);

            Console.WriteLine("请您输入你的等级A~E");
            string str = Console.ReadLine();
            int money;
            if (str == "A")    // = 是赋值     == 是带有判断之意 会将双等号两边的值进行比较，相等返回true 否则false
            {
                 money = 10000 + 500;
                //Console.WriteLine("我的月薪是10000 + 500");
                Console.WriteLine($"我的月薪是{money}");
            }
            else if (str == "B")
            {
                 money = 10000 + 200;
                Console.WriteLine($"我的月薪是{money}");
            }
            else if(str == "C") 
            {
                 money = 10000 + 0;
                Console.WriteLine($"我的月薪是{money}");
            }
            else if (str == "D")
            {
                 money = 10000 -1000;
                Console.WriteLine($"我的月薪是{money}");
            }
            else
            {
                 money = 10000 -3000;
                Console.WriteLine($"我的月薪是{money}");
            }



        }
    }
}
