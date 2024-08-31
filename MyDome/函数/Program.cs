using System.Threading.Channels;

namespace 函数 {
	internal class Program {
		//函数，ref和out，变长参数和参数默认值，函数重载，递归函数


		#region 函数

		#region 函数基本概念
		//函数（方法）
		//代码块的封装
		#endregion

		#region 函数写在哪
		//class语句块中
		//struct语句块中
		#endregion

		#region 基本语法
		//静态关键字 返回值类型 函数名(传参){
		//	函数语句块；
		//	return 返回值；
		//}
		//目前使用static静态关键字（不是必须的）
		//返回值类型可以是任何数据类型（如果不返回值则用void）
		//函数名依据 帕斯卡命名法命名（所有单词首字母大写）
		//传参的格式为：数据类型 参数名，为多个时用“，”隔开（不是必须的）可以是14个基本数据类型+复杂数据类型（数组，枚举，结构体，类class）
		//如果无返回值return可省略，否则须和返回值类型的数据类型相同
		//
		#endregion

		#region 实际应用
		//无参数无返回值函数
		//返回类型void，可省略return

		//有参数无返回值函数
		//传参的格式为：数据类型 参数名，为多个时用“，”隔开（不是必须的）可以是14个基本数据类型+复杂数据类型（数组，枚举，结构体，类class）
		//返回类型void，可省略return

		//无参数有返回值函数
		//不可省略 return 且返回值类型必须相同

		//有参数有返回值函数
		//不可省略 return 且返回值类型必须相同
		//传参的格式为：数据类型 参数名，为多个时用“，”隔开（不是必须的）可以是14个基本数据类型+复杂数据类型（数组，枚举，结构体，类class）

		//有参数有多返回值函数
		//传参的格式为：数据类型 参数名，为多个时用“，”隔开（不是必须的）可以是14个基本数据类型+复杂数据类型（数组，枚举，结构体，类class）
		//有多返回值时必须 返回相应的数据类型！数组！（return new int[]{，，，}）
		#endregion

		#region 关于return
		//即使函数没有返回值，我们也可以使用return,
		//return可以直接不执行后面的代码，直接返回到函数外部
		//例如：
		//static void Speak ( string str ) {
		//	if ( str == "混蛋" ) { 
		//		return;
		//	}
		//	Console.WriteLine(str);
		//}

		#endregion

		#endregion
		
		#region ref和out（函数参数修饰符）

		#region 为什么要学ref和out
		//当函数传参时需要在内部对参数进行重新赋值，同时需要在函数外部对参数值也进行改变
		//如果不使用ref和out函数外部的参数无法进行同步修改
		//当使用ref和out后函数外部的参数才会同步修改
		//作用：解决值类型和引用类型 在函数内部 改值 或者 重新声明 后能够对函数外面的对应参数 让其也被修改
		#endregion

		#region ref和out的使用
		//使用时直接在函数参数类型前加ref或者out
		//同时在调用函数时参数类型前也需要加对应的ref或者out
		#endregion

		#region ref和out的区别
		//ref传入的参数必须初始化 out不用
		//out传入的参数必须在函数内部进行赋值 ref不用
		#endregion

		#endregion

		#region 变长参数和参数默认值

		#region 变长参数关键词
		//params（当需要传入函数的参数有很多时使用，需要写在所有参数的最后一个并且一个函数有且只能出现一个params）（可以传入n个同类型参数，n可以是0）
		//使用时，后面必为 数组
		//数组的类型可以是任意类型
		//函数参数可以有 别的参数 和 params关键字修饰符的参数
		//函数参数中只能最多出现一个params关键字 并且一定是在最后一组参数 前面可以有n个其他参数
		//调用函数时，参数括号内可不写参数值

		//例子：
		//static int Sum( params int[] num) {
		//	int sum = 0;
		//	for ( int i = 0; i < num.Length; i++ ) { 
		//		sum += num[i];
		//	}
		//	return sum;
		//}
		#endregion

		#region 参数默认值
		//有参数默认值的参数 一般称为可选参数
		//作用是： 当调用函数时可不传参，不传参就会使用默认值作为参数的值
		//注意：
		//函数参数支持多个参数默认值，每个参数都可以有默认值
		//如果要混用 可选参数 必须 写在普通参数的后面
		//例子：
		//static void Speak2 ( string test , string name = "lzh" , string str = "我没什么话可说" ) { 
		//}
		#endregion

		#endregion

		#region 函数重载

		#region 基本概念
		//在同一个语句块中函数名相同
		//参数的数量不同
		//或者
		//参数的数量相同，但参数的类型 或 顺序不同

		//减少函数名的数量，避免命名空间的污染
		//提升程序的可读性
		#endregion

		#region 实例

		//注意：
		//重载和返回值类型无关，只和参数类型，个数，顺序有关
		//调用时 程序会自己根据传入的参数类型进行判断，选择使用哪一个重载


		//参数的数量不同

		//数量相同 类型不同

		//数量相同 顺序不同

		//ref和out
		//加了ref或out 也是类型不同（ref和out算同一种数据类型）

		//变长参数也算

		//可选参数不能算类型不同
		//

		#endregion

		#endregion

		#region 递归函数

		#region 基本概念
		//递归函数 就是 让函数自己 调用 自己
		//但是一个正确的递归函数
		//必须有结束调用的条件
		//用于 条件判断的 这个条件 必须能够改变 能够达到停止的目的
		//static void Fun () {
		//	if (false) { 
		//		return;
		//	}
		//	Fun();
		//}
		#endregion

		#region 实例
		//用递归函数 打印出 0-10
		//static void Fun ( int a ) {

		//	if ( a>10 ) {
		//		return;
		//	}
		//	Console.Write(a + " ");
		//	a++;
		//	Fun(a);
		//      }
		#endregion

		#endregion

		#region 函数练习
		static int Compare ( int a , int b ) {
			int max;
			if ( a < b ) {
				max = b;
			} else {
				max = a;
			}
			return max;
		}

		static double[] RoundAL ( double a ) {
			const double PI = 3.14;
			double RoundA = PI*a*a;
			double RoundL = PI*a*2;
			return new double[] { RoundA , RoundL };
		}

		static int[] SumMaxMinMean ( int[] a ) {
			int sum = 0,max = 0,min = 0,mean = 0;
			for ( int i = 0; i < a.Length; i++ ) {
				sum += a[i];
				mean = sum / a.Length;
			}
			for ( int i = 0; i < a.Length - 1; i++ ) {
				if ( a[i] > a[i + 1] ) {
					int temp = a[i];
					a[i] = a[i + 1];
					a[i + 1] = temp;
				}
			}
			max = a[a.Length - 1];
			min = a[0];
			return new int[] { sum , max , min , mean };
		}
		//质数
		static bool PrimeNum ( int num ) {
			for ( int i = 2; i <= num / 2; i++ ) {
				if ( num % i == 0 ) {
					return false;
				}
			}
			return true;
		}

		static bool LeapYear ( int year ) {
			if ( year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ) {
				return true;
			} else {
				return false;
			}
		}
		#endregion

		#region ref和out练习

		static string[] ResultMessage ( string userName , string passWord ) {
			bool Result = false;
			string Message = null;
			if ( userName == "admin" ) {
				if ( passWord == "123456" ) {
					Result = true;
					Message = "登录成功！";
				} else {
					Message = "登录失败，密码错误！";
				}
			} else {
				Message = "登录失败，用户名错误！";
			}
			return new string[] { Result.ToString() , Message };
		}

		#endregion

		#region 变长参数练习

		static int[] SumP ( params int[] arr ) {
			int sum = 0,p=0;
			for ( int i = 0; i < arr.Length; i++ ) {
				sum += arr[i];
				p = sum / arr.Length;
			}
			return new int[] { sum , p };
		}

		#endregion

		#region 递归练习
		static void a(int b){
			if ( b > 10 ) {
				return;
			} else {
                Console.Write(b+" ");
				b++;
            }
			a(b);
		}

		static int b ( int a ) { 
			int Sum = 0;
			for ( int i = 1; i <= a; i++ ) {
				Sum += i;
			}
			return Sum;
		}

		static void C ( int i ,double a ) {
			a = a / 2;
			i--;
            if ( i == 0 ) {
                Console.WriteLine(a);
                return;
			} 
			C(i,a);
		}

		static void D () {
			int a=1; int b=200;
            Console.WriteLine(a);
			a++;
            D();
		}
		/// <summary>
		/// 这里在不使用循环，条件语句的情况下循环1-200的所有数字
		/// 用到了递归函数（相当于循环）以及
		/// 逻辑运算符的短路运用：
		/// &&	当第一个为假时就会不运行后面的同理
		/// ||	当两个都为假时不运行后面的
		/// </summary>
		static bool cww (int i ) {
			Console.Write(i + " ");
			i += 1;
			return i<201 && cww(i);
		}
		#endregion
		#region 函数重载
		static int Battle ( int a , int b ) {
			int MaxValue = 0;
			if ( a > b ) {
				MaxValue = a;
			}
			return MaxValue;
		}

		static float Battle ( float a , float b ) {
			float MaxValue = 0;
			if ( a > b ) {
				MaxValue = a;
			}
			return MaxValue;
		}

		static double Battle ( double a , double b ) {
			double MaxValue = 0;
			if ( a > b ) {
				MaxValue = a;
			}
			return MaxValue;
		}

		

		static void aaa () {
			Console.Write("请输入两个整数：");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			Console.WriteLine(Battle(num1 , num2));
			Console.Write("请输入两个小数F：");
			float num3 = float.Parse(Console.ReadLine());
			float num4 = float.Parse(Console.ReadLine());
			Console.WriteLine(Battle(num3 , num4));
			Console.Write("请输入两个小数：");
			double num5 = double.Parse(Console.ReadLine());
			double num6 = double.Parse(Console.ReadLine());
			Console.WriteLine(Battle(num5 , num6));
		}
		#endregion

		static void Main ( string[] args ) {
			//Console.WriteLine("Hello, World!");
			//Fun( 0 );
			
			cww(1);
			Console.WriteLine(Compare(10 , 20));
            Console.WriteLine();
            Console.WriteLine("圆的面积为："+RoundAL(6)[0] +"，圆的周长为：" + RoundAL(6)[1]);
            Console.WriteLine();
            int[] arr = new int[]{ 1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("总和为："+ SumMaxMinMean(arr)[0]+"，最大值为："+ SumMaxMinMean(arr)[1]+"，最小值为："+ SumMaxMinMean(arr)[2] +"，平均值为："+ SumMaxMinMean(arr)[3]+"。");
            Console.WriteLine();
            Console.WriteLine(PrimeNum(59));
			Console.WriteLine();
			Console.WriteLine(LeapYear(2024));
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
            Console.Write("请输入用户名：");
			string userName = Console.ReadLine();
            Console.Write("请输入密码：");
			string password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(ResultMessage(userName , password)[0] + "\n\n" + ResultMessage(userName , password)[1]);
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
			a(0);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(b(6));
            Console.WriteLine();
            Console.WriteLine(b(10));
            Console.WriteLine();
            C(11,100);
			aaa();
			
			
		}
	}
}
