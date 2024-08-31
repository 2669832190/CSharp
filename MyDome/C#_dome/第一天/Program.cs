namespace 第一天
/*
 * namespace    声明 命名空间（项目名）
 */
{
    internal class Program
    /*
     * internal 访问控制修饰符（内部的 类似 public(公共的) ）
     * class    类---声明类的关键字
     * Program  类名---切记这里的Program 不要理会
     * 
     */
    {
        static void Main(string[] args)
        /*
         * static           静态---访问修饰符
         * void             代表当前方法没有返回值
         * Main             main方法
         * string[] args    函数的参数（形参） -> 对应着实参
         */
        {
            //Console.WriteLine("这是一条输出语句");
            /*
             * Console.WriteLine()  换行输出
             * Console.Write()      直接输出
             */

            /*
             * Console.WriteLine("Hello, World!");
             * Console.WriteLine("123456");
             */

            /*
             * 
             */

            /*for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "*" + i + "=" + (i * j) + "\t");
                }
                Console.WriteLine();
            }*/

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "*" + i + "=" + i * j + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("1.控制台 任意输入一个 数值 几天  返回 几周 零 几天  例 ： 8  一周零一天");
            Console.Write("请输入天数：");
            int DayNum = int.Parse(Console.ReadLine());
            int num00 = DayNum / 7;
            int num01 = DayNum % 7;
            Console.WriteLine("您输入的天数是: " + DayNum + "天 " + num00 + "周零" + num01 + "天");
            Console.WriteLine("");


            Console.WriteLine("2.控制台 任意输入一个 秒数   返回 几天 几个小时 几分钟 几秒  36000");
            Console.Write("请输入秒数：");
            int TimeNum = int.Parse(Console.ReadLine());
            int Day = TimeNum / 86400;
            int Hour = TimeNum % 86400 / 3600;
            int Min = TimeNum % 3600 / 60;
            int Second = TimeNum % 60;
            Console.WriteLine("您输入的秒数是: " + TimeNum + "秒  " + Day + "天 " + Hour + "小时" + Min + "分钟" + Second + "秒");
            Console.WriteLine("");


            Console.WriteLine("3.控制台 任意输入一个3位数 返回 个位 十位 百位");
            Console.Write("请输入一个三位数：");
            int Num = int.Parse(Console.ReadLine());
            int Hnum = Num / 100;
            int Tnum = (Num / 10) % 10;
            int num = Num % 10;

            Console.WriteLine("您输入的三位数是: " + Num + " 个位是:" + num + " 十位是:" + Tnum + " 百位是:" + Hnum);
            Console.WriteLine("");




            Console.WriteLine(" 4.int x = 10; int y = 30; 交换变量 不依赖 第三个变量");
            int x = 10;
            int y = 30;
            Console.WriteLine("交换前：" + x + " " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.Write("交换后：" + x + " " + y);
        }
    }
}
