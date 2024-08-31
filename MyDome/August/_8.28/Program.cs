using System.Security.Cryptography;

namespace _8._28 {
	internal class Program {
		static void Main ( string[] args ) {

			//Console.WriteLine("Hello, World!");
			#region 数组
			int[] arr = new int[]{543,6,76,34,7,895,43,23,324};
            foreach (int arrnum in arr){ Console.Write(arrnum +" "); }
            Console.WriteLine();




			//第一步要循环n轮实现n个数的排序
			for ( int i = 0; i < arr.Length - 1; i++ ) {
				//第二步需要遍历数组，进行交换位置，由于是前一个和后一个进行比较所以，循环的次数为数组的长度-1
				for ( int j = 0; j < arr.Length - 1 - i; j++ ) {
					//第三步进行判断前一个和后一个的大小，如果前一个大于后面的就进行换位置
					if ( arr[j] < arr[j + 1] ) {
						//进行交换位置，方法1：语法糖
						//(arr[j], arr[j+1]) = (arr[j+1], arr[j]);
						//进行换位置，方法2：中间商不赚差价
						int temps = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temps;
					}
				}
			}
			foreach ( int arrnum in arr ) { Console.Write(arrnum + " "); }
			Console.WriteLine();
			#endregion

		}
	}
}