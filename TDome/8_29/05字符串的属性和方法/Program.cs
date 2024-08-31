using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05字符串的属性和方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            //字符串的长度
            Console.WriteLine(str.Length);
            //e 字符串能够使用索引获取某个值 只读的 只能获取 不能修改
            Console.WriteLine(str[1]);
            //str[1] = 'a';
            //转换为字符数组
            char[] chars = str.ToCharArray();
            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            //判断字符串的开头是否是指定的内容
            Console.WriteLine(str.StartsWith("he"));
            Console.WriteLine(str.StartsWith("wor"));
            //判断字符串的结尾是否是指定的内容
            Console.WriteLine(str.EndsWith("rld"));
            Console.WriteLine(str.EndsWith("lo"));

            //查找是否包含子字符串,返回找到的索引,没有返回-1
            Console.WriteLine(str.IndexOf("wo"));
            Console.WriteLine(str.IndexOf("ow"));
            //查找指定子字符串最后一次出现的索引,没有返回-1
            Console.WriteLine(str.LastIndexOf("l"));

            string time = "2024-08-29";
            //分割字符串 为多个字符串
            string[] strs = time.Split('-');
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
