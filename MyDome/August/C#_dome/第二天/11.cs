using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二天
{
    internal class _11
    {
        static void Maina() {
            Console.Write("请输入第一个数：");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("请输入第二个数：");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("请输入第三个数：");
            double num3 = double.Parse(Console.ReadLine());
            //  num1 ? num2
            //  num2 ? num3
            //  num1 ? num3
            //-------------------
            //  num2 ? num3
            //  num3 ? num1
            //  num2 ? num1 

            if ( num1 > num2 ) {
                if ( num2 > num3 ) {
                    //num1>num2>num3
                    Console.WriteLine($"最大值：{num1}，最小值：{num3}");
                } else if ( num1 > num3 ) {
                    //num1 > num2   num1 > num3 num2<num3
                    Console.WriteLine($"最大值：{num1}，最小值：{num2}");
                } else {
					//num1 > num2   num2 < num3   num1 < num3
					Console.WriteLine($"最大值：{num3}，最小值：{num2}");
				}
				//  num2 > num1
			} else if ( num2 > num3 ) {
                //num2 > num1   num2 > num3
                if ( num1 > num3 ) {
                    //num2 > num1   num2 > num3 num1>num3
                    Console.WriteLine($"最大值：{num2},最小值：{num3}");
                } else {
                    Console.WriteLine($"最大值：{num2},最小值：{num1}");
                } 
			} else {
				//num2 > num1   num2 < num3     num1<num2<num3
				Console.WriteLine($"最大值{num3}，最小值：{num1}");
			}















			//a>b
			/*if ( num1 > num2 ) {
                //a>b && b>c
                if ( num2 > num3 ) {
                    Console.WriteLine("最大值：" + num1 + " 最小值：" + num3);
                    //a>b && b<c
                } else if ( num1 > num3 ) {
                    Console.WriteLine("最大值：" + num1 + " 最小值：" + num2);
                } else {
					Console.WriteLine("最大值：" + num3 + " 最小值：" + num2);
				}
			} else if ( num2 > num3 ) {
                if ( num1 > num3 ) {
                    Console.WriteLine("最大值：" + num2 + " 最小值：" + num3);
                } else {
                    Console.WriteLine("最大值：" + num2 + " 最小值：" + num1);
                }
            } else {
                    Console.WriteLine("最大值：" + num3 + " 最小值：" + num2);
			}*/
			/*{
                Console.WriteLine("最大值：" + num3 + " 最小值：" + num1);
            }*/
		}
    }
}
