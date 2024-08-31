namespace _03昨日作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //个税 输入你的 月薪 返回 你交多少税
            //正着写 倒着写   从 30000写    (>  <) 

            Console.WriteLine("请您输入您的月薪");//给用户一个提示信息，告诉他该做什么，
            string str = Console.ReadLine();//获取用户输入的月薪 他是一个字符串
            int MonthMoney = int.Parse(str);//将字符串 转化成数字


            double TaxMonth; //月税
            if (1<= MonthMoney && MonthMoney <= 5000)
            {
                Console.WriteLine("您工资太低，不需要交税");
            }
            else if(5000< MonthMoney && MonthMoney <= 8000)
            {
                //这里需要计算月税
                //MonthMoney这是用户的月薪     5000 是这个阶段的不需要交税的部分
                // 所以交税的部分 就是  MonthMoney - 5000 

                //TaxMonth =  (int)((MonthMoney - 5000) * 0.03);
                TaxMonth = (MonthMoney - 5000) * 0.03;
                Console.WriteLine($"个人所得税税率为3%,你每个月需要交税{TaxMonth}");
            }
            else if (8000< MonthMoney && MonthMoney <= 17000)
            {
                //这里需要计算月税

                TaxMonth = (MonthMoney - 5000) * 0.1;
                Console.WriteLine($"个人所得税税率为10%,你每个月需要交税{TaxMonth}");
            }
            else if (17000 < MonthMoney && MonthMoney <= 30000)
            {
                //这里需要计算月税
                TaxMonth = (MonthMoney - 5000) * 0.2;
                Console.WriteLine($"个人所得税税率为20%,你每个月需要交税{TaxMonth}");
            }
            else if (30000 < MonthMoney && MonthMoney <= 40000)
            {
                //这里需要计算月税
                TaxMonth = (MonthMoney - 5000) * 0.25;
                Console.WriteLine($"个人所得税税率为25%,你每个月需要交税{TaxMonth}");
            }
            else if (40000 < MonthMoney && MonthMoney <= 60000)
            {
                //这里需要计算月税
                TaxMonth = (MonthMoney - 5000) * 0.3;
                Console.WriteLine($"个人所得税税率为30%,你每个月需要交税{TaxMonth}");
            }
            else if (60000 < MonthMoney && MonthMoney <= 85000)
            {
                //这里需要计算月税
                TaxMonth = (MonthMoney - 5000) * 0.35;
                Console.WriteLine($"个人所得税税率为35%,你每个月需要交税{TaxMonth}");
            }
            else
            {
                //这里需要计算月税
                TaxMonth = (MonthMoney - 5000) * 0.45;
                Console.WriteLine($"个人所得税税率为45%,你每个月需要交税{TaxMonth}");
            }







        }
    }
}
