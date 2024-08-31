namespace _8_29 {
	internal class Program {

		#region 函数重载

		//函数重载
		//函数重载就是有多个相同的函数名
		//但是参数的类型不一样
		//参数的数量不一样

		//重载与返回值类型无关

		static int add ( int a , int b ) { 
			int c = a + b;
			return c;
		}
		static int add ( int a , int b ,int c) {
			int d = c + a + b;
			return d;
		}
		static double add ( double a , double b) {
			double c = a + b;
			return c;
		}
		#endregion

		#region 递归
		//递归 就是在函数内部 调用他自己
		//如果没有终止条件 一直死循环 直到堆栈溢出
		public static void print ( int n ) {
			if ( n == 0 ) {
				return;
			}
            Console.WriteLine(n);
			print( n - 1 );
            //Console.WriteLine(n);
        }

		#endregion

		static void Main ( string[] args ) {
			//Console.WriteLine("Hello, World!");
			Console.WriteLine(add(1 , 2));
			Console.WriteLine(add(1 , 2 , 3));
			Console.WriteLine(add(23.6 , 32.6));
			print(10);





        }
	}
}
