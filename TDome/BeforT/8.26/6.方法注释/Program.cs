using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.方法注释
{
    internal class Program
    {
        /// <summary>
        /// 主入口
        /// </summary>
        /// <param name="args">xxxxxx</param>
        static void Main(string[] args)
        {

            //方法注释   方法的作用、参数的解释、返回值等等

            //格式：    ///
            
            int a = 1;

        }
       /// <summary>
       /// 这是一个求两个数的和的方法
       /// </summary>
       /// <param name="a">其中一个数</param>
       /// <param name="b">另一个数</param>
       /// <returns>返回他俩的和</returns>
        public static int Test(int a,int b)
        {
            return a + b;
        }
    }
}
