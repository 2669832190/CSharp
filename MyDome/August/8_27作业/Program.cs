namespace _8_27作业 {

	internal class Program {
		static void Main ( string[] args ) {
			Console.WriteLine("第一题 随机数 6.5 - 12.5 , 并求三个数的和：");
			RandomSum();
			Console.WriteLine();
			//----------------------------------------------------------
			Console.WriteLine("第二题 随机数 -10 - 50 ，并求平均数：");
			RandomAverage();
			Console.WriteLine();
			//----------------------------------------------------------
			Console.WriteLine("第三题学生信息：");
			StudentMessage();
			Console.WriteLine();
			//----------------------------------------------------------
			Console.WriteLine("第四题某月份有多少天：");
			Console.Write("请输入年份：");
			int year = int.Parse( Console.ReadLine() );
			Console.Write("请输入月份：");
			int month = int.Parse( Console.ReadLine() ) ;
			Month(month , year);
			Console.WriteLine();
			//----------------------------------------------------------
			Console.WriteLine("第五题计算器：");
			Console.Write("请输入第一个数：");
			int x = int.Parse( Console.ReadLine() );
		again:
			Console.Write("请输入运算符：");
			string Operator = Console.ReadLine() ;
			if ( Operator == "+" || Operator == "-" || Operator == "*" || Operator == "/" ) {
			} else {
				goto again;
			}
			Console.Write("请输入第二个数：");
			int y = int.Parse( Console.ReadLine() );
			Compute(Operator , x , y);
			Console.WriteLine();
			//----------------------------------------------------------
			Console.WriteLine("第六题抽奖：");
			Lottery();
		}
		/**
		 *  佛曰:
		 *          写字楼里写字间，写字间里程序员；
		 *          程序人员写程序，又拿程序换酒钱。
		 *          酒醒只在网上坐，酒醉还来网下眠；
		 *          酒醉酒醒日复日，网上网下年复年。
		 *          但愿老死电脑间，不愿鞠躬老板前；
		 *          奔驰宝马贵者趣，公交自行程序员。
		 *          别人笑我忒疯癫，我笑自己命太贱；
		 *          不见满街漂亮妹，哪个归得程序员？
		 */


		/**                                                                          
		 *          .,:,,,                                        .::,,,::.          
		 *        .::::,,;;,                                  .,;;:,,....:i:         
		 *        :i,.::::,;i:.      ....,,:::::::::,....   .;i:,.  ......;i.        
		 *        :;..:::;::::i;,,:::;:,,,,,,,,,,..,.,,:::iri:. .,:irsr:,.;i.        
		 *        ;;..,::::;;;;ri,,,.                    ..,,:;s1s1ssrr;,.;r,        
		 *        :;. ,::;ii;:,     . ...................     .;iirri;;;,,;i,        
		 *        ,i. .;ri:.   ... ............................  .,,:;:,,,;i:        
		 *        :s,.;r:... ....................................... .::;::s;        
		 *        ,1r::. .............,,,.,,:,,........................,;iir;        
		 *        ,s;...........     ..::.,;:,,.          ...............,;1s        
		 *       :i,..,.              .,:,,::,.          .......... .......;1,       
		 *      ir,....:rrssr;:,       ,,.,::.     .r5S9989398G95hr;. ....,.:s,      
		 *     ;r,..,s9855513XHAG3i   .,,,,,,,.  ,S931,.,,.;s;s&BHHA8s.,..,..:r:     
		 *    :r;..rGGh,  :SAG;;G@BS:.,,,,,,,,,.r83:      hHH1sXMBHHHM3..,,,,.ir.    
		 *   ,si,.1GS,   sBMAAX&MBMB5,,,,,,:,,.:&8       3@HXHBMBHBBH#X,.,,,,,,rr    
		 *   ;1:,,SH:   .A@&&B#&8H#BS,,,,,,,,,.,5XS,     3@MHABM&59M#As..,,,,:,is,   
		 *  .rr,,,;9&1   hBHHBB&8AMGr,,,,,,,,,,,:h&&9s;   r9&BMHBHMB9:  . .,,,,;ri.  
		 *  :1:....:5&XSi;r8BMBHHA9r:,......,,,,:ii19GG88899XHHH&GSr.      ...,:rs.  
		 *  ;s.     .:sS8G8GG889hi.        ....,,:;:,.:irssrriii:,.        ...,,i1,  
		 *  ;1,         ..,....,,isssi;,        .,,.                      ....,.i1,  
		 *  ;h:               i9HHBMBBHAX9:         .                     ...,,,rs,  
		 *  ,1i..            :A#MBBBBMHB##s                             ....,,,;si.  
		 *  .r1,..        ,..;3BMBBBHBB#Bh.     ..                    ....,,,,,i1;   
		 *   :h;..       .,..;,1XBMMMMBXs,.,, .. :: ,.               ....,,,,,,ss.   
		 *    ih: ..    .;;;, ;;:s58A3i,..    ,. ,.:,,.             ...,,,,,:,s1,    
		 *    .s1,....   .,;sh,  ,iSAXs;.    ,.  ,,.i85            ...,,,,,,:i1;     
		 *     .rh: ...     rXG9XBBM#M#MHAX3hss13&&HHXr         .....,,,,,,,ih;      
		 *      .s5: .....    i598X&&A&AAAAAA&XG851r:       ........,,,,:,,sh;       
		 *      . ihr, ...  .         ..                    ........,,,,,;11:.       
		 *         ,s1i. ...  ..,,,..,,,.,,.,,.,..       ........,,.,,.;s5i.         
		 *          .:s1r,......................       ..............;shs,           
		 *          . .:shr:.  ....                 ..............,ishs.             
		 *              .,issr;,... ...........................,is1s;.               
		 *                 .,is1si;:,....................,:;ir1sr;,                  
		 *                    ..:isssssrrii;::::::;;iirsssssr;:..                    
		 *                         .,::iiirsssssssssrri;;:.                      
		 */


		#region 第一题函数
		static void RandomSum () {
			Random random = new Random();
			double max = 12.5;
			double min = 6.5;
			double sumnum = 0;
			for ( int i = 0; i < 3; i++ ) {
				double RandomNum = random.NextDouble();
				double randomNum = RandomNum * ( max - min ) + min;
				Console.Write("第" + ( i + 1 ) + "个随机数为：" + ( randomNum ) + "\n");
				sumnum += randomNum;
			}
			Console.WriteLine("它们的和为" + sumnum);
		}
		#endregion

		#region 第二题函数

		static void RandomAverage () {
			Random random1 = new Random();
			int max1 = 50;
			int min1 = -10;
			int sum=0;
			for ( int i = 0; i < 3; i++ ) {
				int RandomNum = random1.Next(min1,max1);
				Console.Write("第" + ( i + 1 ) + "个随机数为：" + RandomNum + "\n");
				sum += RandomNum;
				if ( i == 2 ) { Console.WriteLine("平均数为：" + sum / ( i + 1 )); }
			}
		}

		#endregion

		#region 学生信息函数
		static void StudentMessage () {
			Student student = new Student();
			string[] name={ "小明","小红","小刚"};
			int[] age={ 18,31,28};
			Genders genders = new Genders();
			Marriages marriages = new Marriages();
			Hobbys hobbys = new Hobbys();
			for ( int i = 0; i < 3; i++ ) {
				student.Students(name[i] , i % 2 == 0 ? (Genders)0 : (Genders)1 , age[i] , (Marriages)i , (Hobbys)i);
			}
		}
		#endregion

		#region 学生 性别 婚否 爱好
		public enum Genders {
			男,
			女
		}
		public enum Marriages {
			未婚,
			已婚,
			离异
		}
		public enum Hobbys {
			打台球,
			打篮球,
			踢足球
		}
		public struct Student {
			public string Name ;
			public Genders Gender ;
			public int Age ;
			public Marriages Marriage ;
			public Hobbys Hobby ;

			public void Students ( string name , Genders gender , int age , Marriages marriage , Hobbys hobby ) {
				this.Name = name;
				this.Age = age;
				this.Gender = gender;
				this.Marriage = marriage;
				this.Hobby = hobby;
				Console.WriteLine("姓名：" + Name + "，\t性别：" + Gender + "，\t年龄：" + Age + "，\t婚否：" + Marriage + "，\t爱好：" + Hobby + "。");
			}
		}
		#endregion

		#region 计算器函数

		/// <summary>
		/// 加法
		/// </summary>
		static int add ( int x , int y ) {
			return x + y;
		}
		/// <summary>
		/// 减法
		/// </summary>
		static int less ( int x , int y ) {
			return x - y;
		}
		/// <summary>
		/// 乘法
		/// </summary>
		static int multiply ( int x , int y ) {
			return x * y;
		}
		/// <summary>
		/// 除法
		/// </summary>
		static int divide ( int x , int y ) {
			return x / y;
		}
		static void Compute ( string Operator , int x , int y ) {
			switch ( Operator ) {
				case "+":
					Console.WriteLine(x + Operator + y + "=" + add(x , y));
					break;
				case "-":
					Console.WriteLine(x + Operator + y + "=" + less(x , y));
					break;
				case "*":
					Console.WriteLine(x + Operator + y + "=" + multiply(x , y));
					break;
				case "/":
					Console.WriteLine(x + Operator + y + "=" + divide(x , y));
					break;
			}
		}
		#endregion

		#region 月份天数判断
		public static void Month ( int month , int year ) {
			switch ( month ) {
				case 2:
					if ( ( year % 4 == 0 && year % 100 != 0 ) || year % 400 == 0 ) {
						Console.WriteLine(year + "年" + month + "月有29天");
					} else {
						Console.WriteLine(year + "年" + month + "月有28天");
					}
					break;
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.WriteLine(year + "年" + month + "月有31天");
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.WriteLine(year + "年" + month + "月有30天");
					break;
			}
		}

		#endregion

		#region 抽奖函数
		static void Lottery () {
			Random random2 = new Random();
			double yess = 0.01;
			int count = 0;
			bool won =false;
			while ( !won ) {
				count++;
				if ( count > 40 && yess < 1 ) {
					yess += 0.01;
				}
				if ( random2.NextDouble() < yess ) {
					won = true;
					Console.WriteLine("恭喜您中奖了，您共抽取" + count + "次。");
				}
			}
		}

		#endregion


	}
}
