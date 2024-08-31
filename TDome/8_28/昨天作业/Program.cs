using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_28
{
    //字段有：姓名，性别，年龄，婚否，爱好...
    public struct Student
    {
        public string _name;
        public Gender _gender;
        public int _age;
        public Marry _marry;
    }
    public enum Gender
    {
        男,
        女
    }
    public enum Marry
    {
        未婚,
        已婚,
        离异
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 随机3个6.5-12.5之间的数，输出这3个数的和
            //实例化Random
            Random ran = new Random();

            //最小值 0 * 6 + 6.5 = 6.5
            //最大值 1 * 6 + 6.5 = 12.5
            double d1 = ran.NextDouble() * 6 + 6.5;
            double d2 = ran.NextDouble() * 6 + 6.5;
            double d3 = ran.NextDouble() * 6 + 6.5;
            Console.WriteLine("这三个数的和是:" + (d1 + d2 + d3));

            //2. 随机3个-10到50之间的数，输出他们的平均数
            int i1 = ran.Next(-10, 50);
            int i2 = ran.Next(-10, 50);
            int i3 = ran.Next(-10, 50);
            Console.WriteLine("这三个数的平均数是:" + ((i1 + i2 + i3) / 3));

            //3. 用结构体结合枚举，保存三个学生的信息，字段有：姓名，性别，年龄，婚否，爱好...
            //必须用到结构体和枚举
            Student stu1;
            stu1._name = "张三";
            stu1._gender = Gender.男;
            stu1._age = 20;
            stu1._marry = Marry.未婚;

            Student stu2;
            stu1._name = "李四";
            stu1._gender = Gender.男;
            stu1._age = 18;
            stu1._marry = Marry.未婚;

            Student stu3;
            stu1._name = "王五";
            stu1._gender = Gender.女;
            stu1._age = 25;
            stu1._marry = Marry.未婚;


            //4. 输入年份和月份，输出这个月有多少天
            Console.WriteLine("请输入一个年份:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入一个月份:");
            int m = int.Parse(Console.ReadLine());
            /*
                        int day = DateTime.DaysInMonth(y, m);
                        Console.WriteLine("对应的天数是:" + day);
            */
            //分支结构
            //通过判断月份,得出天数
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("这个月有31天");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("这个月有30天");
                    break;
                case 2:
                    if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                    {
                        Console.WriteLine("这个月有29天");
                    }
                    else
                    {
                        Console.WriteLine("这个月有28天");
                    }
                    break;
            }

        /*5. 计算器
             先输入一个数字
             再输入一个运算符(只能输入+ - * /，如果不是，重新输入)
             再输入一个数字
             计算最终结果并输出
        */
        Question5:
            Console.WriteLine("请输入一个数字");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入一个运算符");
            string symbol = Console.ReadLine();
            Console.WriteLine("请再输入一个数字");
            int num2 = int.Parse(Console.ReadLine());
            //判断这个符号
            switch (symbol)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("不是合法的运算符,请重新输入");
                    goto Question5;
            }

            /*
             * 6. 抽奖，第一次抽奖抽中的概率是1%，若40次未抽中，从第41次开始，每抽一次，中奖率增加1%，直到抽到为止
               输出抽了多少次才抽到奖品
            */
            //中奖率 抽奖的时候随机0-100,随机出的结果小于等于中奖率,视为中奖
            int winningRate = 2;
            //抽奖次数
            int number = 0;
            //不知道循环多少次 所以使用while
            while (true)
            {
                //每抽一次 次数+1
                number++;
                //进行一次抽奖 得到的结果  [1,100]
                int result = ran.Next(1, 101);
                //是否抽中了奖品
                if (result <= winningRate)
                {
                    Console.WriteLine($"抽到了奖品,用了{number}次");
                    break;
                }
                else
                {
                    //没有抽到奖品
                    if(number > 40)
                    {
                        winningRate++;
                    }
                }
            }
        }
    }
}
