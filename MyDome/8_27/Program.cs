namespace _8_27 {
	internal class Program {
		static void Main ( string[] args ) {
			//随机数的声明
			Random random = new Random();
			//new	创建对象用的		Random需要被实例化后才能使用


			//随机数的原理
			//new Random(种子号（时间戳）);
			//当创建随机数对象时在括号内写入相同的时间戳随机数就会相同
			Random ran1 = new Random(123);
			Random ran2 = new Random(123);
			//没有使用种子号时，默认是当前时间到1970年1月1日的豪秒数
			//如果在一毫秒中运行多个随机数（不含种子号）时，那么随机数将会相同



			//随机数的使用
			int randomnum = random.Next();
			//获取一个小于x的随机整数(括号内有一个参数时表示随机数的范围为0-x,左闭右开)
			int x = 10;
			int randomnum1 = random.Next(x);
			//获取一个10-100之间的随机
			int a=10;
			int b=100;
			int randomnum2 = random.Next(a,b);
			//随机一个 0-1 之间的小数
			double randomnum0 = random.NextDouble();
			Console.WriteLine(randomnum0 * 10);


			//相同种子号
			int rannum1 =ran1.Next();
			//int rannum3 =ran1.Next();
			int rannum2 =ran2.Next();
			Console.WriteLine(rannum1 + " " + rannum2);


		}
	}
}
