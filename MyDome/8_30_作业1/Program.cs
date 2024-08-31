using System;

namespace _8_30_作业1 {
	internal class Program {

		static void Main ( string[] args ) {
            Console.WriteLine("Hello, World!");
			Console.WriteLine("第一题：");
			a();
            //a(parint);
            Console.WriteLine();
         
            Console.WriteLine("第二题：");
			b(Battle);
            Console.WriteLine();
            Console.WriteLine("第三题：");
			c();
            Console.WriteLine();
            Console.WriteLine("第四题：");
			d();
			//d_1();
            Console.WriteLine();
            Console.WriteLine("第五题：");
			e();
            Console.WriteLine();
            Console.WriteLine("第六题：");
			f();
            Console.WriteLine();
            Console.WriteLine("第七题：");
			g();
            Console.WriteLine();
            Console.WriteLine("第八题：");
			h();
            Console.WriteLine();
            Console.WriteLine("第九题：");
			i();

			//---------------------------------------------------
			/*int x=10;
			int y =x < 50 ? x < 10 ?  x < 5 ? 3 : 4 : ++x : x--;
			int y1 =x-- + x-- +x--;
			Console.WriteLine(y);
			Console.WriteLine(y1);
			double num1 = 1.56;
			double num2 = 1.4;
            Console.WriteLine((int)num1);
            Console.WriteLine((int)num2);
			char aa = 'A';
			int aanum = 97;
			if ( (int)aa>=48 && (int)aa<=57 ) {
				Console.WriteLine(aa);
			} else {
                Console.WriteLine(false);
            }
			 */
		}
		#region 1
		static void a () {
			double[] Doublenums = { 11.1 , 4.43 , 45.0 , 60 , 56.5 , -10 , 5 , -11.1 };
			foreach ( double d in Doublenums ) { Console.Write(d + " "); }
			Console.WriteLine();
			parint(Doublenums);
		}

		static void parint ( double[] nums) { 
			for ( int i = 0; i < nums.Length; i++ ) {
				if ( nums[i] == (int)nums[i] && nums[i] > 0 ) {
                    Console.Write(nums[i] + " ");
                }
			}
            Console.WriteLine();
        }
		#endregion

		#region 1_1
		static void a ( Action<Double[]> F ) {
			double[] Doublenums = { 11.1 , 4.43 , 45 , 60 , 56.5 , -10 , 5 , -11.1 };
			foreach ( double d in Doublenums ) { Console.Write(d + " "); }
			Console.WriteLine();
			F(Doublenums);
		}
		static void parint1 ( double[] Doublenums ) {
			int num =0;
			for ( int i = 0; i < Doublenums.Length; i++ ) {
				if ( int.TryParse(Doublenums[i].ToString(), out num) ) {
					if ( num > 0 ) {
						Console.Write(num+" ");
					}
				}
			}
            Console.WriteLine();
        }
		#endregion

		#region 2
		static void b ( Action<int , int , int[]> F ) {
			int[] nums = new int[10];
			int sum = 0;
			int index = 0;
			F(index , sum , nums);
		}
		static void Battle ( int index , int sum , int[] nums ) {
			for ( int i = 0; i < nums.Length; i++ ) {
				Console.Write("请输入第\t" + ( i + 1 ) + "\t个同学的成绩：");
				nums[i] = int.Parse(Console.ReadLine());
			}
			for ( int i = 0; i < nums.Length; i++ ) {
				sum += nums[i];
				index = sum / nums.Length;
			}
			Console.Write("高于平均分的学生成绩有：");
			for ( int i = 0; i < nums.Length; i++ ) {
				if ( nums[i] > index ) {
					Console.Write(nums[i] + " ");
				}
			}
			Console.WriteLine();
		}
		#endregion

		#region 3

		static void c () {
			string str = null;
			int [] nums = new int[3];
			for ( int i = 0; i < nums.Length; i++ ) {
				switch ( i ) {
					case 0:
						str = "时";
						break;
					case 1:
						str = "分";
						break;
					case 2:
						str = "秒";
						break;
				}
				Console.Write("请输入第" + ( i + 1 ) + "个整数（"+ str +"）：");
				nums[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine(nums[0] + "(时)：" + nums[1] + "(分)：" + nums[2] + "(秒)，是今天的第" + Second(nums) + "秒。");
		}

		static int Second ( int[] arr ) {
			int sum=0;
			sum = arr[0] * 60 * 60 + arr[1] * 60 + arr[2];
			return sum;
		}

		#endregion

		#region 4

		static void d () {
			Console.Write("请输入一个字符串：");
			string str = Console.ReadLine();
			NumsCount(str);
		}

		static void NumsCount (string str) {
			int count =0;
			char[] chars = str.ToCharArray();
			for ( int i = 0; i < chars.Length; i++ ) {
				if ( (int)chars[i] > 48 && (int)chars[i] < 57 ) { 
					count++;
				}
			}
			Console.WriteLine(str + "数字字符一共有：" + count + "个。");
		}
		#endregion

		#region 4_1
		static void d_1 () {
			Console.Write("请输入一个字符串：");
			string str = Console.ReadLine();
			Statistics(str);
		}

		static void Statistics ( string str ) {
			int num;
			int count = 0;
			char[] chars = str.ToCharArray();
			for ( int i = 0; i < chars.Length; i++ ) {
				if ( int.TryParse(chars[i].ToString() , out num) ) {
					count++;
				}
			}
			Console.WriteLine(str + "数字字符一共有：" + count + "个。");
		}
		#endregion

		#region 5

		static void e () {
			Random rnd = new Random();
			int[] nums = new int[rnd.Next(3,11)];
			for ( int i = 0; i < nums.Length; i++ ) {
				nums[i] = rnd.Next(1 , 101);
			}
			ArrAyNums(nums);
		}

		static void ArrAyNums ( int[] nums ) {
			Console.Write("[");
			for ( int i = 0; i < nums.Length; i++ ) {
				if ( i == nums.Length - 1 ) {
					Console.Write(nums[i]);
				} else {
					Console.Write(nums[i] + ",");
				}
			}
			Console.WriteLine("]");
		}
		#endregion

		#region 6
		static void f () {
			for ( int i = 1; i < 101; i++ ) {
				if ( is7(i) ) {
					continue;
				} else {
					Console.Write(i + " ");
				}
			}
		}

		static bool is7 ( int i ) {
			bool isYes = false;
			int num =-1;
			num = i.ToString().IndexOf("7");
			if ( num != -1 || i % 7 == 0 ) {
				isYes = true;
			}
			return isYes;
		}
		#endregion

		#region 7
		static void g () {
			int[][]Arraynums = ArrAyNums();
			PrintArraynums2(Arraynums);
		}

		static void PrintArraynums2 ( int[][] ArrAynums ) {
			Console.WriteLine("[");
			for ( int i = 0; i < ArrAynums.GetLength(0); i++ ) {
				PrintArraynums(ArrAynums[i]);
			}
			Console.WriteLine("]");
		}
		static void PrintArraynums ( int[] nums ) {
			Console.Write("  [");
			for ( int i = 0; i < nums.Length; i++ ) {
				if ( i == ( nums.Length - 1 ) ) {
					Console.Write(nums[i]);
				} else {
					Console.Write(nums[i] + ",");
				}
			}
			Console.WriteLine("]");
		}

		static int[][] ArrAyNums () {
			int[][] Arraynums = new int[2][]{
				new int[]{1,2,3,4 },
				new int[]{5,6,7,8,9,10 }
			};
			return Arraynums;
		}
		#endregion

		#region 8
		static void h () {
			Console.Write("请输入一个数：");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine("比" + num + "大的 第一个 能被7 整除的数为：" + ten(num));
		}

		static int ten ( int Num ) {
			int num = 0;
			for ( int i = Num; true; i++ ) {
				if ( i % 7 == 0 && i != Num ) {
					num = i; break;
				}
			}
			return num;
		}
		#endregion

		#region 9
		static void i () {
			Console.Write("请输入一个数：");
			int num = int.Parse(Console.ReadLine());
			int[] nums = fbmqsl(num);
			Console.WriteLine("斐波那契数列第 " + num + " 位的数字为：" + nums[num - 1]);
		}

		static int[] fbmqsl ( int Num ) {
			int[] ints = new int[Num];
			for ( int i = 0; i < ints.Length; i++ ) {
				if ( i <= 1 ) {
					ints[i] = 1;
				} else {
					ints[i] = ints[i - 1] + ints[i - 2];
				}
			}
			return ints;
		}
		#endregion
	}
}
