using System;

namespace _8_28作业 {
	internal class Program {

		static void Main ( string[] args ) {
            #region 1
            Console.WriteLine("第一题：");
			int[] nums =rAndom(10,101);
            ArrayCW(nums);
			Console.WriteLine("上述数组中的最小值为：" + ArrayMinNum(nums));
			Console.WriteLine();
            #endregion

            #region 2
            //2.创建一个int数组（内容不限），计算数组中所有数的和
            Console.WriteLine("第二题：");
            int[] nums1 = rAndom(5,101);
			ArrayCW(nums1);
			Console.WriteLine("上述数组中所有数的和为：" + ArraySum(nums1));
            Console.WriteLine();
            #endregion

            #region 3
            string[] StudentName = { "小明","小红","小刚","张三","李四","王五","赵六"};
			Named(StudentName);
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 4
            Console.WriteLine("第四题：");
            int[,] arrtwo = new int[5,2];
			int numbegin =1;
			for ( int j = 0; j < arrtwo.GetLength(0); j++ ) {
				for ( int k = 0; k < arrtwo.GetLength(1); k++ ) {
					arrtwo[j , k] = numbegin;
					numbegin++;
				}
			}
            Console.WriteLine("原二维数组为：");
            ArrayCWTwo(arrtwo);
            Console.WriteLine();
			Change(2 , 4 , arrtwo);
            Console.WriteLine("交换第二行和第四行的内容后的数组内容为：");
            ArrayCWTwo(arrtwo);
            Console.WriteLine();
			#endregion

			#region 5
			Console.WriteLine("第五题：");
			int[] ints = rAndom(10 , 100);
			ArrayCW(ints);
			Console.Write("请输入一个数字：");
			int num = int.Parse( Console.ReadLine() );
			if ( ArrayFind(num , ints) == null ) {
                Console.WriteLine();
                Console.WriteLine("！！！提示：数字 \"" + num + "\" 在该数组中没有出现过!");
			} else { 
				Console.WriteLine("数字 \""+num+"\" 第一次出现在数组的 第"+ ArrayFind(num,ints) + "个 位置。");
			}
			#endregion
		}
		/**
		 **************************************************************
		 *                                                            *
		 *   .=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-.       *
		 *    |                     ______                     |      *
		 *    |                  .-"      "-.                  |      *
		 *    |                 /            \                 |      *
		 *    |     _          |              |          _     |      *
		 *    |    ( \         |,  .-.  .-.  ,|         / )    |      *
		 *    |     > "=._     | )(__/  \__)( |     _.=" <     |      *
		 *    |    (_/"=._"=._ |/     /\     \| _.="_.="\_)    |      *
		 *    |           "=._"(_     ^^     _)"_.="           |      *
		 *    |               "=\__|IIIIII|__/="               |      *
		 *    |              _.="| \IIIIII/ |"=._              |      *
		 *    |    _     _.="_.="\          /"=._"=._     _    |      *
		 *    |   ( \_.="_.="     `--------`     "=._"=._/ )   |      *
		 *    |    > _.="                            "=._ <    |      *
		 *    |   (_/                                    \_)   |      *
		 *    |                                                |      *
		 *    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-='      *
		 *                                                            *
		 *           LASCIATE OGNI SPERANZA, VOI CH'ENTRATE           *
		 **************************************************************
		 */

		#region 随机生成数组

		/// <summary>
		/// 随机数
		/// </summary>
		/// <param name="ArrayLength">数组的长度</param>
		/// <param name="MaxNum">最大值范围</param>
		/// <returns>返回数组</returns>
		static int[] rAndom ( int ArrayLength , int MaxNum ) {
			Random random = new Random();
			int[] nums = new int[ArrayLength];
			for ( int i = 0; i < nums.Length; i++ ) {
				nums[i] = random.Next(MaxNum);
			}
			return nums;
		}
		#endregion

		#region 数组遍历方法
		/// <summary>
		/// 一维数组遍历
		/// </summary>
		/// <param name="num">需要遍历的一维数组</param>
		static void ArrayCW ( int[] num ) {
			Console.Write("数组：[");
			for ( int i = 0; i < num.Length; i++ ) {
				if ( i == num.Length - 1 ) {
					Console.Write(num[i]);
				} else {
					Console.Write(num[i] + ", ");
				}
			}
			Console.WriteLine("]");
		}
		/// <summary>
		/// 二维数组的遍历
		/// </summary>
		/// <param name="num">需要遍历的二维数组</param>
		static void ArrayCWTwo ( int[,] num ) {
			for ( int i = 0; i < num.GetLength(0); i++ ) {
				Console.Write("第" + ( i + 1 ) + "行： ");
				for ( int j = 0; j < num.GetLength(1); j++ ) {
					if ( j == num.GetLength(1) - 1 ) {
						Console.Write(num[i , j]);
					} else {
						Console.Write(num[i , j] + ", ");
					}
				}
				Console.WriteLine();
			}
		}
		#endregion

		#region 一维数组方法
		/// <summary>
		/// 查找一维数组最小值
		/// </summary>
		/// <param name="num">需要查找的数组</param>
		static int ArrayMinNum ( int[] num ) {
			int minnum = num[0];
			for ( int i = 1; i < num.Length; i++ ) {
				if ( minnum > num[i] ) {
					minnum = num[i];
				}
			}
			return minnum;
		}
		/// <summary>
		/// 数组所有元素的和
		/// </summary>
		/// <param name="num">需要求和的数组</param>
		/// <returns>数组的和</returns>
		static int ArraySum ( int[] num ) {
			int sum = 0;
			for ( int i = 0; i < num.Length; i++ ) {
				sum += num[i];
			}
			return sum;
		}
		/// <summary>
		/// 查找与数组中的相同的元素，并返回在数组中的位置
		/// </summary>
		/// <param name="num">需要用来查找的数字</param>
		/// <param name="nums">需要查找的数组</param>
		/// <returns>存在数组中的位置</returns>
		static int? ArrayFind ( int num , int[] nums ) {
			int? same = null;
			for ( int i = 0; i < nums.Length; i++ ) {
				if ( num == nums[i] ) {
					same = i + 1;
					break;
				} else {
					same = null;
				}
			}
			return same;
		}
		#endregion

		#region 二维数组交换某两行的内容方法
		/// <summary>
		/// 二维数组交换某两行的内容方法
		/// </summary>
		/// <param name="a">需要交换的某行a</param>
		/// <param name="b">需要交换的某行b</param>
		/// <param name="num">需要交换的二维数组</param>
		static void Change ( int a , int b , int[,] num ) {
			int[] temp = new int[num.GetLength(1)];
			for ( int i = 0; i < num.GetLength(1); i++ ) {
				temp[i] = num[( a - 1 ) , i];
				num[( a - 1 ) , i] = num[( b - 1 ) , i];
				num[( b - 1 ) , i] = temp[i];
			}
		}
		#endregion

		#region 点名器

		/// <summary>
		/// 随机输出数组中的任意一个（不重复）
		/// </summary>
		/// <param name="StudentName">需要使用的字符串数组</param>
		static void Named ( string[] StudentName ) {
			Random random = new Random();
			bool[] repeat = new bool[StudentName.Length];
			for ( int i = 0; i < StudentName.Length; i++ ) {
			again:
				int studentnamenum = random.Next(StudentName.Length);
				if ( repeat[studentnamenum] ) {
					goto again;
				} else {
					repeat[studentnamenum] = true;
				}
				Console.Write(StudentName[studentnamenum] + "\t");
				Console.ReadKey(true);
			}
		}
		#endregion
	}
}
