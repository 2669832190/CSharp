namespace 高阶函数 {
	internal class Program {

		static void Test(Action f ) {
			f();
		}

		static void CWHW() { 
			Console.WriteLine("Hello, World!");
		}

		static void Main ( string[] args ) {
			Test(CWHW);
		}
	}
}
