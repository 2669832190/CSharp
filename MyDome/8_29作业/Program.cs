namespace _8_29作业 {
	internal class Program {
		static void Main ( string[] args ) {
			Console.WriteLine("第一题：\n");
			_Rectangle rect = new _Rectangle();
			rect.beginS(rect);
			Console.WriteLine("\n");
			//-------------------------------------------------------------------------------------------------
			Console.WriteLine("第二题：\n");
			Arrayif arrayif = new Arrayif();
			arrayif.num = Arrayif.ints();
			arrayif.str = new string[] { "h" , "e" , "l" , "l" , "o" , " " , "w" , "o" , "r" , "l" , "d" };
			Arrayif.Arrayifs(arrayif.num);
            Console.WriteLine();
            Arrayif.Arrayifs(arrayif.str);
			Console.WriteLine("\n");
			//-------------------------------------------------------------------------------------------------
			Console.WriteLine("第三题：\n");
			int num = 0;
			Print(ref num , ChangeA());
			Console.WriteLine("\n");
			//-------------------------------------------------------------------------------------------------
			Console.WriteLine("第四题：\n");
			Console.WriteLine("请输入回文字符串：");
			string str = Console.ReadLine();
			Console.WriteLine(Palindrome(str) + "\n\n");
			//-------------------------------------------------------------------------------------------------
			Console.WriteLine("第五题：\n");
			initialize();
		}
/**
 *  .--,       .--,
 * ( (  \.---./  ) )
 *  '.__/o   o\__.'
 *     {=  ^  =}
 *      >  -  <
 *     /       \
 *    //       \\
 *   //|   .   |\\
 *   "'\       /'"_.-~^`'-.
 *      \  _  /--'         `
 *    ___)( )(___
 *   (((__) (__)))    高山仰止,景行行止.虽不能至,心向往之。
 */














































		#region 第一题
		struct _Rectangle {

			public int width;
			public int height;
			public int RectangleS ( int width , int height ) {
				return width * height;
			}
			public int RectangleS ( int height ) {
				return (int)Math.Pow(height , 2);

			}
			public void beginS ( _Rectangle rect ) {
				Random random = new Random();
				rect.width = random.Next(1 , 11);
				rect.height = random.Next(1 , 11);
				Console.WriteLine("长方形的长为：" + rect.height + ",长方形的宽为：" + rect.width);
				Console.WriteLine("长方形的面积为：" + rect.RectangleS(rect.width , rect.height));
                Console.WriteLine();
                rect.height = random.Next(50 , 101);
				Console.WriteLine("正方形的边长为：" + rect.height);
				Console.WriteLine("正方形的面积为：" + rect.RectangleS(rect.height));
			}
		}

		#endregion

		#region 第二题
		struct Arrayif {
			public int[] num;
			public string[] str;

			public static int[] ints () {
				Random random = new Random();
				int[] nums = new int[random.Next(1,11)];
				for ( int i = 0; i < nums.Length; i++ ) {
					nums[i] = random.Next();
				}
				return nums;
			}

			public static void Arrayifs ( int[] num ) {
				Console.WriteLine("函数的参数为整型数组，数组的长度为：" + num.Length);
			}
			public static void Arrayifs ( string[] str ) {
				Console.Write("函数的参数为字符串数组，该数组的元素有：");
				foreach ( string i in str ) { Console.Write(i + " "); }
				Console.WriteLine();
			}
		}


		#endregion

		#region 第三题
		public static void Print ( ref int count , char[] num ) {
			if ( count < num.Length - 1 ) {
				Console.Write(num[count]);
				count++;
				Print(ref count , num);
			} else if ( count == num.Length - 1 ) {
				Console.WriteLine(num[count]);
				return;
			}
		}
		public static char[] ChangeA () {
			Random r = new Random();
			int num = r.Next(1,10000);
			Console.WriteLine("正整数：" + num+"\n");
			char[] chars = num.ToString().ToCharArray();
			Array.Reverse(chars);
			Console.Write("反转后：");
			return chars;
		}
		#endregion

		#region 第四题

		public static bool Palindrome ( string str ) {
			bool Isyes = true;
			char[] chars = str.ToCharArray();
			Array.Reverse(chars);
			char[] chars1 = str.ToCharArray();
			for ( int i = 0; i < chars1.Length; i++ ) {
				if ( chars1[i] != chars[i] ) {
					Isyes = false;
				}
			}
			return Isyes;
		}

		#endregion

		#region 第五题

		public static void initialize () {
			int count = 0 ;
			int[] nums = {1,2,3,4,5,3,2,1,6,5,3,2,1};
			foreach ( int i in nums ) { Console.Write(i + " "); }
			Console.WriteLine();
			Console.Write("请输入一个数字：");
			int num = int.Parse(Console.ReadLine());
			judgment(num , count , nums);
		}

		static void judgment ( int num , int count , int[] nums ) {
			for ( int i = 0; i < nums.Length; i++ ) {
				if ( num == nums[i] ) {
					count++;
				}
				if ( count == 2 ) {
					//Console.WriteLine("该值第二次出现在第" + i + "个索引的位置。");
					Console.WriteLine("数字" + nums[i] + "第二次出现在第" + i + "个索引的位置。");
                    break;
				} else if ( i == nums.Length - 1 && count == 1 ) {
					Console.WriteLine("该值未在数组中出现第二次！");
				} else if ( i == nums.Length - 1 && count == 0 ) {
					Console.WriteLine("该值未在数组中出现！");
				}
			}
		}
		#endregion
	}
}
