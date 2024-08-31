using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.数据类型1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //在C#中，变量分为以下类型
            //1.值类型（基本数据类型）
            //2.引用类型


            //值类型
            //值类型变量保存的这个值本身

            //数值类型：
            //8位无符号整数类型  范围0-255（也叫做字节类型）
            byte b = 255;
            //byte c = 300;
            //8位有符号整数类型  范围-128到127
            sbyte b1 = -128;
            //sbyte b2 = -130;

            //16位无符号整数类型  范围0-65535
            ushort s1 = 65535;
            //16位有符号整数类型  范围-32768到32767
            short s2 = -32768;

            //32位无符号整数类型  范围0-4294967295
            uint i1 = 4294967295;
            //32位有符号整数类型  范围-2147483648 到 2147483647
            int i2 = -2147483648;

            //64位无符号整数类型  范围0 到 18446744073709551615
            ulong ul1 = 18446744073709551615;
            //64位有符号整数类型  范围-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807
            long ul2 = -9223372036854775808;

            //小数数值类型（浮点型）
            //单精度浮点数  大约6-8位数字（占4个字节）
            //注意：数字后面加后缀F或f
            float f1 = 1.23456f;
            //双精度浮点数   大约15-17位数字（占8个字节）
            //数字后面不需要添加后缀，默认就是double,也可以加后缀D或d
            double d1 = 1.23456789999999;

            //128位精确的十进制   28-29有效数字
            //后面加上后缀M或m
            decimal dec1 = 10.2131242423123m;

            /*总结：
                整数 byte,sbyte<ushort,short<uint,int<ulong,long
                小数 float<double<decimal

                整数中能存储负值的有：sbyte,short,int,long
                小数都可以存储负值*/


            //布尔类型   bool   用来表示真或假（对或错）   只有两个值   true/false
            bool bol1 = true;
            bol1 = false;
            //bol1 = 123;

            //字符类型  char  使用单引号包裹  只能存储一个字符（数字、字母、符号、中文）
            char c1 = 'a';
            char c2 = '1';
            char c3 = '$';
            char c4 = '坤';


            //枚举类型  限制一个变量只能是某几个值中的一个
            //1.定义一个枚举类型（放在类里边定义，不写在方法里）
            //声明变量的时候，设置该变量的数据类型为这个枚举类型
            Sex sex = Sex.man;
            //int sex = 100;
            Console.WriteLine(sex);
            //Console.BackgroundColor = ConsoleColor.Green;

        }

        //定义枚举：名字以大写字母开头
        /*enum 自己起的名字
        {
            枚举的成员
        }*/

        enum Sex
        {
            man,
            woman,
        }

    }
}
