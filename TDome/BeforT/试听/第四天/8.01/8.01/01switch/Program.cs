namespace _01switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明变量   
            //格式 ： 数据类型 +  名称
            // int num;
            // 给变量赋值
            // num = 10；

            //bool flag = false;
            //if (表示布尔类型的表达式)
            //{
            //在这个位置，如果执行代码，则证明，小括号中是 true
            //}
            //else
            //{
            //小括号里是false
            //}
            //简单讲  if 和 else 表示二选一
            //执行哪一个 是根据 小括号最终的布尔值来决定的





            ////switch (){}
            //Console.WriteLine("请您输入您的名字");
            //string name = Console.ReadLine();//Console.ReadLine(); 接收用户在控制台输入的字符串

            ////switch("阿呆")
            //switch (name) //双引号引起来的东西都是字符串 string
            //{
            //    //switch(这里是你要匹配的对象) 
            //    //挨个与case 后面的值 进行匹配，
            //    //匹配成功，则执行对应值后面的语句
            //    case "笨蛋":
            //        Console.WriteLine("我是笨蛋");
            //        break;
            //    case "阿呆":
            //        Console.WriteLine("我是阿呆");
            //        break; //当匹配成功之后，后续的case将没有必要再进行匹配
            //               //所以添加break；跳出switch，
            //    case "阿瓜":
            //        Console.WriteLine("我是阿瓜");
            //        break;
            //    case "张三":
            //        Console.WriteLine("我是张三");
            //        break;
            //    default:
            //        Console.WriteLine("我不知道我是什么");
            //        break;

            //}

            //int num = 10;
            //switch (参与对比(匹配)的变量 ) 
            // {
            //       case 跟变量匹配的值 :
            //            如果匹配成功，执行这里的代码语句
            //            break;
            //       case 跟变量匹配的值 :
            //            如果匹配成功，执行这里的代码语句
            //            break;
            //       case 跟变量匹配的值 :
            //            如果匹配成功，执行这里的代码语句
            //            break;
            //       case 跟变量匹配的值 :
            //            如果匹配成功，执行这里的代码语句
            //            break;
            //       defalt:
            //            如果上面所有的case全部没有匹配成功，则执行dealt中的语句代码
            //            break;
            // }


            string name = Console.ReadLine();
            switch (name)
            {

                case "瞅瞅":
                case "笨蛋"://如果多个case 也就是多个标签值，执行相同的代码块，则可以把上面case的代码删掉  
                case "阿呆":
                    Console.WriteLine("吃冰淇凌");
                    break; 
                case "阿瓜":
                    Console.WriteLine("想吃西瓜");
                    break;
                case "张三":
                    Console.WriteLine("回家睡觉");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

            //if (true)
            //{
                
            //}
            //else
            //{
                
            //}

        }
    }
}
