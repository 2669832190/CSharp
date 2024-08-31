namespace _04whiile循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true) //死循环  停不下来
            //{
            //    Console.WriteLine("我不知道我是啥");
            //}

            //while (true)
            //{
                
            //}
            //while循环需要的条件
            //1.循环之外定义一个变量
            //2.循环之内的小括号，定义循环区间
            //3.循环之内的大括号，定义增量

            int x = 1;  // 定义变量
            int count = 0; //定义一个  记录循环次数的变量
            while (x < 10000000000) // 决定循环区间
            {
                Console.WriteLine("我想看看循环几次");
                //x += 1;
                x = x + 5;   //需要对变量有一个增值
                //=  是赋值，是 将右边的值 给到 左边

                //count+=1;
                count = count + 1;
                //Console.WriteLine($"第{count}次循环");记录count的变化
            }
            Console.WriteLine($"第{count}次循环"); //在循环结束之后，打印count的值就可以了，
            Console.WriteLine("我什么时候执行");

        }
    }
}
