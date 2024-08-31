using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05GUID唯一标识
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GUID 全球唯一标识缩写
            //依靠 计算机当前系统时间 以及 计算机的硬件ID码... 计算得出128位的随机数  无限接近唯一
            //一般用于 生成秘钥 订单号 ...
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
        }
    }
}
