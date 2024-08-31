using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.数据类型2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //引用类型
            //引用类型不包含存储在变量中的实际数据，但他们包含的是对变量的引用
            //引用类型保存的是数据的内存地址


            #region 字符串类型
            //string 字符串类型  用双引号包裹的   用于存储多个字符
            //创建字符串的三种方式   ""      @""       $""

            string name = "张三";
            //转义字符    \n 换行符       \t 制表符
            string test = "人家\n今年\t十八\t岁";
            Console.WriteLine(test);

            //可以使用\进行转义的转义
            string test1 = "人家\\n今年\\t十八\\t岁";
            Console.WriteLine(test1);


            //@""    创建的字符串可以不使用转义就能正常显示特殊字符（写啥就是啥）
            string test2 = @"人家\n今年\t十八\t岁";
            Console.WriteLine(test2);

            //  "比较特殊   需要用""表示
            string test3 = @"人家\n今""年\t十八\t岁";
            Console.WriteLine(test3);


            //$""    可以插入变量
            string test4 = $"名字：{name},年龄：{test}";
            Console.WriteLine(test4);
            #endregion

            #region object对象类型
            //object  是所有数据类型的父类型，object可以表示任意的数据类型
            object o1 = 123;
            object o2 = "123";
            object o3 = true;
            object o4 = Sex.man;

            //我们可以定义自己的类,实例化对应的对象，存储一系列相关数据
            //对象的创建需要依赖于类
            //对象和类之间的关系：
            //类：是一系列对象的描述，是一个模板                 人类
            //对象：是类的一个具体表现，我们也称之为类的实例     张三


            //创建一个Friend类型的对象  她就是类的实例
            Friend friend = new Friend();
            //使用  对象名.类的成员名  的方式操作对象
            friend.Name = "张三";
            friend.isMan = true;
            friend.age = 18;
            Console.WriteLine($"我有一个朋友叫{friend.Name},他是不是人？{friend.isMan},他的年龄是{friend.age}岁");
            #endregion

            //dynamic动态类型  也可以存储任意的数据类型
            dynamic d1 = 123;
            dynamic d2 = "kunkun";
            dynamic d3 = false;

            //dynamic 动态类型的校验在运行期间进行（类型错误也可以运行）
            Console.WriteLine(d3 * 100);

            //object 对象类型的校验在编译阶段进行（类型错误，运行不了）
            //Console.WriteLine(o3 * 100);



        }
        enum Sex 
        {
            man,
            woman,
        }
    }

    //类  在namespace命名空间中使用class定义一个类    它是对象的模板  就像上边说的“人类” 不是一个人   而是“人”的模板
    //首字母大写
    class Friend
    {
        //类的内部的东西  称之为类的成员
        //声明类的成员的格式：public 数据类型 成员的名称
        public string Name;
        public bool isMan;
        public int age;
    }

}
