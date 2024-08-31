using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace  声明命名空间
//你可以把它想象成一个仓库，登记一下
namespace _1.知识点补充
{

    //class:声明类的关键字
    //类：是一种数据结构   它可以封装方法、数据或者说其他的类
    //所有的语句不能写在命名空间里，要写在类中

    internal class Program

    //Main  整个程序的主入口，你写的代码，想要执行就必须写到这里边
    //每一个项目有且只能有一个入口
    //Main 入口函数的默认名字    不建议修改
    {
        static void Main(string[] args)
        {
            //注释：
            //单行注释    //     ctrl+k+c
            //多行注释    /*    */      ctrl+shift+?

            /*Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");*/

            //   #region 起一个名字
            //   #endregion

            #region 某一个代码块
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            #endregion


            //快捷键：
            //ctrl+z   撤回
            //ctrl+y   恢复

            //ctrl+s   保存

            //ctrl+k+d   格式化文档




        }
    }
}
