using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06枚举类型转换
{
    public enum Gender
    {
        男 = 10,
        女,
        武装直升机 = 25,
        沃尔玛塑料袋
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //int 和枚举类型 可以直接强制转换
            Console.WriteLine((int)Gender.武装直升机);
            Console.WriteLine((Gender)26);

            //枚举类型转换为字符串类型
            Console.WriteLine(Gender.武装直升机.ToString());
            string str = "沃尔玛塑料袋";

            //字符串转换为枚举类型
            //工作中一般用不到,面试可能用到
            Console.WriteLine((Gender)Enum.Parse(typeof(Gender), str));

            //typeof 获取对应的数据类型
            Console.WriteLine(typeof(Int32));
            Console.WriteLine(typeof(Gender));
            
        }
    }
}
