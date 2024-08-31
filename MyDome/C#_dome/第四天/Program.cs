namespace 第四天 {
	internal class Program {

		static void Main ( string[] args ) {
			//Console.WriteLine("Hello, World!");

			//选择语句：switch
			//	格式:	switch(表达式){
			//				case 常量值1：
			//					语句体1；
			//					break;	--->(由于switch语句的case选项是唯一确定的正确值，所以要终止运行后面的case和default)
			//				case 常量值2：
			//					语句体2；
			//					break;
			//				case 常量值3：
			//					语句体3；
			//					break;
			//				......
			//				default:
			//					语句体；
			//					break;
			//			}
			//
			//
			//
			//循环语句：while:
			//  格式：
			//      int i = 0；                          //循环外定义循环"i"
			//      while( 确定i的取值范围，即循环次数 ){
			//          i++;                            //每执行一次循环，i将自增1，需要注意的是自增语句需要放在最后！！！
			//          语句；
			//      }
			//
			//
			//
			//

			//----------------------------------------
			/*
            int i = 0;
            int sum = 0;
            while ( i <= 100 ) {

				sum += i;
				i++;
			}
			Console.WriteLine($"0-100的和为:{sum}");
            */


			/*Console.WriteLine("请输入您的年龄：");
            int age =int.Parse( Console.ReadLine() );
            int num1;
            if ( age >= 0 && age < 6 ) {
                num1 = 0;
            } else if ( age >= 60 && age<=100) {
                num1 = 5;
            } else if ( age >= 30 && age < 60) {
                num1 = 4;
            } else if ( age >= 18 && age < 30) {
                num1 = 3;
            } else if ( age >= 14 && age < 6) {
                num1 = 2;
            } else if ( age >= 6 && age <14) { 
                num1 = 1;
            } else {
                num1 = 6;
            }
            switch (num1) {
                case 0:
                    Console.WriteLine("幼年");
                    break;
				case 1:
					Console.WriteLine("少年");
					break;
				case 2:
					Console.WriteLine("青年");
					break;
				case 3:
					Console.WriteLine("壮年");
					break;
				case 4:
					Console.WriteLine("中年");
					break;
				case 5:
					Console.WriteLine("老年");
					break;

                default:
                    Console.WriteLine("你丫是妖怪吧");
                    break;
            }*/



			//--------------------------------------------\
			/*
            Console.WriteLine("请输入成绩(0-99)：");
            int num1 = int.Parse( Console.ReadLine() );
            switch (num1/10) {
                case 9:
                    Console.WriteLine("A");
                    break;
				case 8:
					Console.WriteLine("B");
					break;
				case 7:
					Console.WriteLine("C");
					break;
				case 6:
					Console.WriteLine("D");
					break;
                default:
					Console.WriteLine("E");
					break;

			}
            */
			//
			//-------------------------------------------------------------------
			//
			//1. 用 while continue 算一下 1 - 1000  所有 不能被 7 整除的 整数 之和
			int sum = 0;
			int count = 1 ;
			while ( count <= 1000 ) {
				if ( count % 7 == 0 ) {
					count++;
					continue;
				} else {
					sum += count;
				}
				count++;
			}
            Console.WriteLine($"1-1000 所有 不能被 7 整除的 整数 之和为：{sum}");
			Console.WriteLine();
			//------------------------------------------------------------------------
			//
			//2 某车间有26名工人，每人每天可以生产800个螺钉或1000个螺母，1个螺钉需要配2个螺母，为使每天生产的螺钉和螺母刚好配套．生产螺钉和螺母的工人各为多少人时，才能使生产的铁片恰好配套？
			//
			//26人，
			//800螺丝/1000螺母
			//
			//
			int maxValue = 26;
			int i = 1;
			int value;
			while (i<=maxValue) {
				if ( 2*800*i == 1000*(26-i) ) { 
					value = i;
					break;
				}
				i++;
			}
            Console.WriteLine($"当生产螺钉的工人为:{i}人，生产螺母的工人为:{maxValue-i}人时，才能使生产的铁片恰好配套");
            Console.WriteLine();
			//------------------------------------------------------------------------------------------------
			//1600*i == 1000*(26-i) 
			//2*800*i
			//
			//
			//3. 甲、乙班组工人，按计划本月应共生产680个零件，实际甲组超额20％，乙组超额15％完成了本月任务，因此比原计划多生产118个零件。问本月原计划每组各生产多少个零件？
			//
			//

			int sum1 = 680;
			int more = 118;
			int j = 0;
			int JValue = 0;
			while ( j <= sum1 ) {
				if ( 0.2 * j + 0.15 * ( sum1 - j ) == 118 ) {
					JValue = j;
					break;
				}
				j++;
			}
            Console.WriteLine($"本月原计划甲班为：{JValue}，乙班为：{sum1 - JValue}");
            Console.WriteLine();
			//---------------------------------------------------------------------------
			//
			//
			//4. 一个两位数，十位数与个位上的数之和为11，如果把十位上的数与个位上的数对调得到比原来的数大63，原来的两位数是多少？
			//
			//
			//

			int unitNum = 0;
			int z = 0;
			int sum2 = 11;
			int more1 = 63;
			while ( z <= sum2 ) {
				if (10 * z + ( 11 - z ) - ( z + 10 * ( 11 - z ) ) == more1) { 
					unitNum = z;
					break;
				}
				z++;
			}
            Console.WriteLine($"原来的两位数为:{sum2 - unitNum}{unitNum}");
            Console.WriteLine();
			//----------------------------------------------------------------------------------------------------------------
			//
			//5. 一列火车匀速行驶，经过一条长300米的隧道需要20秒的时间，隧道的顶上有一盏灯，垂直向下发光，灯光照在火车上的时间是10秒，求火车的长度和速度各为多少？
			//
			//隧道300m
			//经过隧道的时间20s
			//
			//灯照时间10s
			//
			//求火车长度和速度


			/*int S1 = 300;//(m)
			int S2=0;
			int T1 = 20;//(s)
			int T = 10;//(s)*/


			int s=0;
			int S = 0;//(m)
			while ( S <= 301 ) {
				if ( 300+S==20*10 ) {
					s = S;
					break;
				}
				S++;
			}
			Console.WriteLine($"火车的长度为：{s}m，速度为：{(300+s)/20}m/s");
			Console.WriteLine();
			//------------------------------------------------------------------
			//
			//
			//
			//6. 某市为提倡节约用水，采取分段收费，	若每户每月用水不超过20 立方米，每立方米收费2元；
			//									若用水超过20 立方米，超过部分每立方米加收1元．
			//									小明家5月份交水费64元，则他家该月用水量是多少立方米
			//
			//
			//
			int waterMoney = 64;
			int money = 2;
			int moreMoney = 3;
			int standard = 20;
			int water = 0;
			int Money = 0;
			if ( waterMoney > money * standard ) {
				Money = waterMoney - money * standard;
                Console.WriteLine($"该月用水量为：{Money+standard}立方米");
            } else {
				water = waterMoney / money;
                Console.WriteLine($"该月用水量为：{water}立方米");
            }



            //
            //要求用户输入 用户名 admin 密码 123456  输对了就提示登录成功 输错了 (给提示 错哪儿了) 3次机会  三次机会已结束 账号锁定1min  ；
            //
            Console.WriteLine();
            bool temp = false;
			int count1 = 3;
			do {
                Console.WriteLine("请输入账号：");
				string user = Console.ReadLine();
				Console.WriteLine("请输入密码：");
				string password = Console.ReadLine();
				if ( user == "admin" ) {
					if ( password == "123456" ) {
                        Console.WriteLine("登录成功");
						temp = true;
                    } else {
                        Console.WriteLine("密码错误");
						
						if ( count1 == 0 ) {
							Console.WriteLine("三次机会已结束 账号锁定1min");
						} else {
							Console.WriteLine($"您还剩{count1}次机会");
						}
						count1--;
					}
				} else {
                    Console.WriteLine("账号错误");
					
					if ( count1 == 0 ) {
                        Console.WriteLine("三次机会已结束 账号锁定1min");
                    }else {
						Console.WriteLine($"您还剩{count1}次机会");
					}
					count1--;
				}

			} while ( temp!=true && count1>=0);
			Console.WriteLine();

			//-----------------------------------------
			//1-2100   差值不为4年的闰年挑出来
			//循环1-2100进行年份输出
			//
			//判断是否模100和400为0，若为0则再次判断是否模4为0，为否时输出
			//
			//
			int[] arr = new int[533];
			int a=0;
			for ( int iii = 1; iii < 2200; iii++ ) {
				if ( (iii%100!=0 && iii%4==0)||iii%400==0 ) {
					arr[a] = iii;
					a++;
				}
			}
			for ( int iii = 0; iii < arr.Length; iii++ ) {
				if ( iii != 0 && arr[iii] - arr[iii-1]!=4 ) {
					Console.WriteLine($"在公元1年到公元2100年之间不是4年一闰的年份有:{arr[iii-1]}年,{arr[iii]}年");
					continue;
				}
			}
			
			//找出 1 - 1000  所有的 素数 ， （只能被 1 和 本身 整除 ） 
			//
			//1.循环从二开始，
			//2.再次循环范围为从二到上一个范围的一半，让第一个循环的循环数与第二个循环循环数进行取模，如果摸为0，则不为质数！
			//3.输出质数
			//
			//
			//
			Console.WriteLine();
			for ( int ii = 1; ii < 1001; ii++ ) {
				bool temp111 = true;
				if ( ii==1 ) temp111 = false;
				for ( int jj = 2; jj <= ii / 2 ; jj++ ) {
					if (ii%jj==0) { 
						temp111 = false; 
						break;
					}
				}
				if ( temp111 ) {
					Console.Write($"{ii} ");
				}
			}

			















			
		}
	}
}
