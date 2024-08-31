using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TangShidome {
	internal class 入门实战 {
		static void Maina ( string[] args ) {
            #region 补充必要知识点
            //控制台相关
            //输出
            Console.WriteLine("换行输出");
			Console.Write("不换行输出");
			//输入
			Console.ReadLine();//输入多个
			Console.ReadKey();//输入一个字符
			char c =Console.ReadKey().KeyChar;//输入一个字符时存在char类型里
			char c1 =Console.ReadKey(true).KeyChar;//输入语句中加“true”就不会把输入的内容显示在控制台上

			//控制台其他方法
			//1.清空
			Console.Clear();
			//2.设置控制台大小
			//窗口大小 缓冲区大小
			//注意：
			//1.先设置窗口大小，再设置缓冲区大小
			//2.缓冲区大小不能小于窗口的大小
			//3.窗口的大小不能大于控制台最大尺寸
			//
			//
			//窗口大小
			Console. SetWindowSize(100,50);
			//缓冲区大小(画布的大小，可打印内容区域的宽高)
			Console. SetBufferSize(1000,1000);
			//Console.BufferWidth	缓冲区宽度
			//Console.BufferHeight	缓冲区高度
			//
			//3.设置光标的位置
			//以左上角为原点（0，0）
			//右侧是x轴的正方向
			//下方是y轴的正方向
			//它是一个平面二维坐标系
			//注意：
			//1.边界问题
			//2.横纵距离单位不同 1y=2x 视觉上的
			Console.SetCursorPosition(5,5);
			Console.SetCursorPosition(10,5);
            Console.WriteLine("123");
            //
            //
            //4.设置颜色相关
			//文字颜色设置
			Console.ForegroundColor = ConsoleColor.Green;
			//背景颜色设置
			Console.BackgroundColor = ConsoleColor.Blue;
			//重置背景颜色过后，需要clear一次 才能把整个背景颜色改变
			Console.Clear();
			//
			//
			//5.光标显隐
			Console.CursorVisible = false;


			//6.关闭控制台
			Environment.Exit(0); 


			//随机数
			//创建随机数对象
			//Random	类似自定义的变量类型
			//Random 随机数变量名 = new Random();
			Random r = new Random();

			//生成随机数
			int i = r.Next();//生成一个非负数的随机数产生的数会比较大，不经常用
            Console.WriteLine(i);
			i = r.Next(100);//生成一个（0-99）的随机数，左闭右开（可取0，不可取100）
            Console.WriteLine(i);
			i = r.Next(5,10);//生成一个（5-9）的随机数，左闭右开（可取5，不可取10）


			#endregion
		}
	}
}
