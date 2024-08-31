namespace _03switch练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用户输入 成绩  ；返回用户的 评分
            //>= 90  A
            //>= 80  B
            //>= 70  C
            //>= 60  D
            //< 60   E

            Console.WriteLine("请您输入您的成绩");
            string str = Console.ReadLine();
            int chengji = int.Parse(str);
            string level = "";
            switch (chengji / 10) 
            {
                case 9:
                    level = "A";
                    //Console.WriteLine("您的评分为A");
                    break;
                case 8:
                    level = "B";
                    //Console.WriteLine("您的评分为B");
                    break;
                case 7:
                    level = "C";
                    //Console.WriteLine("您的评分为C");
                    break;
                case 6:
                    level = "D";
                    //Console.WriteLine("您的评分为D");
                    break;
                default:
                    level = "E";
                    //Console.WriteLine("您的评分为E");
                    break;
            }
            Console.WriteLine($"您的评分为{level}");





        }
    }
}
