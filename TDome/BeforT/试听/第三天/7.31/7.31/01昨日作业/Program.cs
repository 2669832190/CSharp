namespace _01昨日作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //设小明有x个苹果 小红有y个橘子


            // int整数类型   double小数类型     string字符串""
            //int num ; //声明一个变量    数据类型 + 名称

            //string aa;
            //aa = "hajskdi";

            //string bb = "我是一个字符串";


            //          输入年龄 弹出 对应的阶段(if  else if  else)
            //[ )

            //      0 - 6     幼年 含0 不含6

            //                  6 - 14    少年

            //                  14 - 18   青年

            //                  18 - 30   壮年

            //                  30 - 60   中年

            //                  60 - 100  老年

            //假设 输入的年龄是  30

            Console.WriteLine("请您输入一个正常的年龄");
            string str;
            str = Console.ReadLine(); //Console.ReadLine()可以拿到用户在控制台输入的东西，
                                      //因为拿过来的是字符串，所以需要字符串类型的变量存储起来

            //int num = int.Parse(str); //num代表用户输入的年龄
             
            int age = int.Parse(str);
            //Console.WriteLine(0 <= age && age < 6);
            if (0 <= age && age < 6)
            {
                Console.WriteLine("您是一个幼年");
            }
            else if(6 <= age && age < 14)
            {
                Console.WriteLine("你是一个少年");
            }else if (18 <= age && age < 30)
            {
                Console.WriteLine("您是一个壮年");
            }
            else if(30<= age && age<60)
            {
                Console.WriteLine("您是一个中年");
            }
            else if (60 <= age && age <= 100)
            {
                Console.WriteLine("您是一个老年人");
            }
            else
            {
                Console.WriteLine("您不是个人");
            }

















        }
    }
}
