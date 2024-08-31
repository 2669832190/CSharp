using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.方法的参数
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //上个项目中的方法     功能单一    十分死板
            //假如说我想输出10次   就只能再封装一个新的方法
            //这两个需求其实是相似的，我们就可以通过参数，来控制同一个方法做出不同的功能

            //参数：形参   和   实参
            //形参：    形式参数    方法定义的时候小括号中的变量，形参的值是由实参决定的
            //实参：    实际参数    方法调用的时候小括号中的数据，这个数据就会赋值给对应位置的形参
            Test(1,"字符串");
            Test(2,"隔壁老王");

            //1.方法中定义了形参，调用时必须传递实参
            //2.实参的数据类型和定义形参的数据类型保持一致
            Ikun(5,"唱跳Rap");
            Ikun(10,"篮球");

            //调用方法传递实参的时候，不仅可以直接写数据，也可以放一个变量，会自动将变量的值传递给形参
            int i1 = 5;
            string s1 = "kunkun";
            Ikun(i1,s1);


            //参数的默认值
            Ikun2(5);
            Ikun2(5,"kunkun");

                    
        }

        public static void Test(int x,string y)
        {
            Console.WriteLine($"x:{x},y:{y}");
        }

        public static void Ikun(int count,string text)
        {
            for(int i = 0;i<count;i++)
            {
                Console.WriteLine(text);
            }
        }

        //定义时形参可以直接给一个默认值的，当你调用方法传递参数的时候没有写具体的数据，则使用默认值（可选）
        //可选（有默认值）参数必须写在必选（无默认值）后面


        //比如：
        //F(int a,int b)    正确，两个必选
        //F(int a,int b =666)    正确，可选放在必选后面
        //F(int a = 666,int b =888)   正确，两个可选
        //F(int a = 666,int b )    错误，可选不能放在必选前面

        public static void Ikun2(int count,string text = "劣迹明星")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(text);
            }
        }

    }
}
