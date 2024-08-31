namespace 第二天 {
	internal class Program {
		static void Main ( string[] args ) {
			/*隐式转换，强制转换*/
			int x = 10;
			double y = x;       //隐式类型转换
			double x1 = 10.5;
			int y1 = (int)x1;   //强制类型转换


			double x2 = 10.55;
			//float y2 = 11.0;

			/*隐式类型转换规则：byte、short、char --> int  -->  long  -->  float  -->  double    */
			/*强制类型转换格式：数据类型 变量名 = （数据类型）被转数据值*/
			//Console.WriteLine("Hello, World!");









			/*输入年龄 弹出 对应的阶段 (if  else if  else)
		[ )
		0-6     幼年  			含0 不含6
					6-14    少年
					14-18   青年
					18-30   壮年
					30-60   中年
					60-...  老年
			 */
			Console.Write("请输入年龄：");
			int age =int.Parse(Console.ReadLine());
			//age=48
			//  0<=age<6    
			//  6<=age




			/* if (条件) { 
				 语句；
			 }
			 else { 
				 语句；
			 }


			 if (条件)
			 {
				 语句；
			 }
			 else
			 {
				 语句；
			 }
 */
			/*if (age == 0 && age<6){
				Console.WriteLine("幼年");
			}else if (age >= 6 && age < 14){
				Console.WriteLine("少年");
			}else if (age >= 14 && age < 18){
				Console.WriteLine("青年");
			}else if (age >= 18 && age < 30){
				Console.WriteLine("壮年");
			}else if (age >= 30 && age < 60){
				Console.WriteLine("中年");
			}else {
				Console.WriteLine("老年");
			}*/
			if ( age == 0 && age < 6 ) {
				Console.WriteLine("幼年");
			} else if ( age >= 60 ) {
				Console.WriteLine("老年");
			} else if ( age >= 30 ) {
				Console.WriteLine("中年");
			} else if ( age >= 18 ) {
				Console.WriteLine("壮年");
			} else if ( age >= 14 ) {
				Console.WriteLine("青年");
			} else {
				Console.WriteLine("少年");
			}
			Console.WriteLine();

			/* ABCDE 五个等级  年底考核 你现在的工资是 1w  ； A +500   b +200  c +0  d-1000  e -3000    输入一个等级 返回 明年的月薪   (if  else if  else)*/
			Console.Write("请输入一个等级（A-E）:");
			int[] arr0 = { 500, 200, 0, -1000, -3000 };
			string str = Console.ReadLine();
			if ( str.Equals("A") ) {
				Console.WriteLine("你明年的月薪是:" + ( 10000 + arr0[0] ));
				//Console.WriteLine($"你明年的月薪是:{10000+arr0[0]}");
			} else if ( str.Equals("B") ) {
				Console.WriteLine("你明年的月薪是:" + ( 10000 + arr0[1] ));
			} else if ( str.Equals("C") ) {
				Console.WriteLine("你明年的月薪是:" + ( 10000 + arr0[2] ));
			} else if ( str.Equals("D") ) {
				Console.WriteLine("你明年的月薪是:" + ( 10000 + arr0[3] ));
			} else if ( str.Equals("E") ) {
				Console.WriteLine("你明年的月薪是:" + ( 10000 + arr0[4] ));
			}
			Console.WriteLine();
			/*个税 输入你的 月薪 返回 你交多少税 正着写 倒着写   从 30000写*/
			/*
			 * 30000        20%
			 * 30000-40000  25%
			 * 40000-60000  30%
			 * 60000-85000  35%
			 * 85000        45%
			 */

			Console.Write("请输入您的月薪：");
			int wages = int.Parse(Console.ReadLine());
			if ( wages == 30000 ) {
				Console.WriteLine("您需要缴纳" + ( ( wages - 5000 ) * 0.2 ) + "个人所得税。");
			} else if ( wages >= 85000 ) {
				Console.WriteLine("您需要缴纳" + ( ( wages - 5000 ) * 0.45 ) + "个人所得税。");
			} else if ( wages > 30000 && wages <= 40000 ) {
				Console.WriteLine("您需要缴纳" + ( ( wages - 5000 ) * 0.25 ) + "个人所得税。");
			} else if ( wages < 85000 && wages > 60000 ) {
				Console.WriteLine("您需要缴纳" + ( ( wages - 5000 ) * 0.35 ) + "个人所得税。");
			} else if ( wages <= 60000 && wages > 40000 ) {
				Console.WriteLine("您需要缴纳" + ( ( wages - 5000 ) * 0.3 ) + "个人所得税。");
			}
			Console.WriteLine();


			/*用户输入 3个数字 找到 最大的和 最小的   (if  else if  else)   (不能使用 逻辑运算符 )*/

			Console.WriteLine("请输入第一个数：");
			double num1 = double.Parse(Console.ReadLine());
			Console.WriteLine("请输入第二个数：");
			double num2 = double.Parse(Console.ReadLine());
			Console.WriteLine("请输入第三个数：");
			double num3 = double.Parse(Console.ReadLine());
			if ( num1 > num2 ) {
				if ( num2 > num3 ) {
					Console.WriteLine("最大值：" + num1 + " 最小值：" + num3);
				} else if ( num1 > num3 ) {
					Console.WriteLine("最大值：" + num1 + " 最小值：" + num2);
				}
			} else if ( num2 > num3 ) {
				if ( num1 > num3 ) {
					Console.WriteLine("最大值：" + num2 + " 最小值：" + num3);
				} else {
					Console.WriteLine("最大值：" + num2 + " 最小值：" + num1);
				}
			} else {
				Console.WriteLine("最大值：" + num3 + " 最小值：" + num1);
			}


			/*
			 * 三个数循环三次输入提示i
			 * 数组在外
			 * 进入第二个循环进行冒泡排序
			 * 
			 * 
			 */

			//----------------------------------------------------

			double[] arr = new double[3];
			double temp = 0;
			for ( int i = 1; i < 4; i++ ) {
				Console.WriteLine("请输入第" + i + "个数：");
				double num = double.Parse(Console.ReadLine());
				arr[( i - 1 )] = num;
			}
			for ( int i = 0; i < arr.Length; i++ ) {
				for ( int j = 0; j < arr.Length - 1; j++ ) {
					if ( arr[j] > arr[j + 1] ) {
						temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
			Console.WriteLine("最大值:" + arr[2] + " 最小值:" + arr[0]);
			Console.WriteLine();
			/*用户 输入一个年份  在输入一个 月份  返回 对应年份 对应月份的天数   （结合 闰年判断 处理 2月）  用if*/
			/*
			 * 输入年份，月份
			 * 对年份进行处理（/4）
			 * 月份：
			 *      4 6 9 11            30
			 *      1 3 5 7 8 10 12     31
			 *      2   28 29
			 *      
			 *  判断月份是否在4 6 9 11
			 *  如果在直接输出30
			 *  如果不在判断是否为2月若为否输出31，否输出28/29
			 */
			int[] months = {4,6,9,11};
			Console.WriteLine("请输入一个年份：");
			int year = int.Parse(Console.ReadLine());
			Console.WriteLine("请输入一个月份：");
			int month = int.Parse(Console.ReadLine());
			if ( month != 2 ) {

				for ( int i = 0; i < months.Length; i++ ) {
					if ( month == months[i] ) {
						Console.WriteLine("年份：" + year + " 月份：" + month + " 天数：30");
						Console.WriteLine();
						break;
					} else {
						Console.WriteLine("年份：" + year + " 月份：" + month + " 天数：31");
						Console.WriteLine();
						break;
					}
				}
			} else {
				if ( year % 4 == 0 ) {
					Console.WriteLine("年份：" + year + " 月份：" + month + " 天数：29");
					Console.WriteLine();
				} else {
					Console.WriteLine("年份：" + year + " 月份：" + month + " 天数：28");
					Console.WriteLine();
				}
			}

			//--------------------------------------------------------------------
			//闰年
			/*if (year % 4 == 0)
			{
				for (int i = 0; i < months.Length; i++) {
					if (month == months[i])
					{
						Console.WriteLine("年份：" + year + " 月份：" + month + "天数：30");
					}
					else if (month == 2)
					{
						Console.WriteLine("年份：" + year + " 月份：" + month + "天数：28");
					}
					else { 
						Console.WriteLine("年份：" + year + " 月份：" + month + "天数：31");

					}
				}
			}
			//平年
			else {
				for (int i = 0; i < months.Length; i++)
				{
					if (month == months[i])
					{
						Console.WriteLine("年份：" + year + " 月份：" + month + "天数：30");
					}
					else if (month == 2)
					{
						Console.WriteLine("年份：" + year + " 月份：" + month + "天数：29");
					}
					else
					{
						Console.WriteLine("年份：" + year + " 月份：" + month + "天数：31");

					}
				}
			}*/


			/*提示用户输入账号 密码 （admin 123456） 都输对了  直接提示你想提示的   ；输错了 提示 账号错了 还是密码错了  错的话 三次机会 ;用完还不对 提示你想提示的 */
			for ( int i = 4; i > 0; i-- ) {
				Console.Write("请输入账号：");
				string user = Console.ReadLine();
				Console.Write("请输入密码：");
				string pass = Console.ReadLine();
				Console.WriteLine();
				if ( user.Equals("admin") ) {
					if ( pass.Equals("123456") ) {
						Console.WriteLine("登录成功！");
						Console.WriteLine();
						break;
					} else {
						Console.WriteLine("咋搞的密码怎么搞错了，再想想，再想想！");
						Console.WriteLine("您还剩" + ( i - 1 ) + "次机会!");
						Console.WriteLine();
					}
				} else {
					Console.WriteLine("想啥呢账号都能错！");
					Console.WriteLine("您还剩" + ( i - 1 ) + "次机会!");
					Console.WriteLine();
				}

			}
			/*用户输入 4个数字 找到 最大的和 最小的   (if  else if  else)*/
			double[] arr1 = new double[4];
			double temp1 = 0;
			for ( int i = 1; i < 5; i++ ) {
				Console.WriteLine("请输入第" + i + "个数：");
				double num11 = double.Parse(Console.ReadLine());
				arr1[( i - 1 )] = num11;
			}
			for ( int i = 0; i < arr1.Length; i++ ) {
				for ( int j = 0; j < arr1.Length - 1; j++ ) {
					if ( arr1[j] > arr1[j + 1] ) {
						temp1 = arr1[j];
						arr1[j] = arr1[j + 1];
						arr1[j + 1] = temp1;
					}
				}
			}
			Console.WriteLine("最大值:" + arr1[3] + " 最小值:" + arr1[0]);
			Console.WriteLine();

			Console.ReadKey();
		}
	}
}
