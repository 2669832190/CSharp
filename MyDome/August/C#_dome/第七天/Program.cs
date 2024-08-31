namespace 第七天 {
	internal class Program {
		static void Main ( string[] args ) {
			//Console.WriteLine("Hello, World!");
			//编写一个 for 循环 , 打印 5 - 15 之间的 数 , 遇到 9 是 使用 continue 跳过 
			for ( int i = 5; i < 15; i++ ) {
				if (i==9) {
					continue;
				} else {
                    Console.Write($"{i} ");
                }
			}
            Console.WriteLine();
			Console.WriteLine();
            //编写一个 for 循环 , 打印 5 - 15 之间 能被 3 整除的 数 , 遇到 9 是 使用 continue 跳过 
            for ( int i = 5; i < 15; i++)
            {
                if ( i==9 ) {
                    continue;
                } else if ( i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
                else { 
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //输入一个数字  n ，判断  n  是否为回文数。（回文数是指从左向右读和从右向左读都一样的数字）
            Console.Write("请输入一个数字：");
            string num = Console.ReadLine();
            string num2 = "";
            //判断是否为回文数
            //num2 += num[i];   --->将字符串看作数组，将输入的字符串进行从后向前输出并保存到新字符串中，最后进行字符串比较，得出是否为回文数！
            //num2 += num.Substring(i,i);   --->将输入的字符串进行逐个截取并通过字符串拼接的方式赋值给新的字符串变量，最后进行字符串比较，得出是否为回文数！
            for ( int i = num.Length-1; i >= 0 ; i--)
            {
                num2 += num[i];
                //num2 += num.Substring(i,i);
            }
            
			if ( num == num2 ) {
                Console.WriteLine(true);
            } else {
                Console.WriteLine(false);
            }
            Console.WriteLine();
            //猴子吃桃
            //总共有多少桃子
            int sum=1;
            for ( int i = 10; i>1; i-- ) {
                sum = ( sum + 1 ) * 2;
			}
			Console.WriteLine(sum);
			Console.WriteLine();
			//Console.WriteLine(sum);
			//Console.WriteLine($"{num3} + 1");

			//不死神兔
			/*
			月数		对数		只数
			1		1		2
			2		1		2
			3		3		6
			4		3
			5		9
			6		9
			7		27
			8		27
			9		81
			10		81
			11		243
			12		243
            */
			/*int numm=1;
			for ( int i = 1; i <= 12; i++ ) {
				if ( i == 1 || i % 2 == 0 ) {
					continue;
				} else {
					numm *= 4;
				}
			}
            Console.WriteLine($"一共有{numm}对兔子");*/
			int tu=0;
			int tu1=1;
			int tu2=1;

			for ( int i = 1; i < 12; i++ ) {
				tu = tu1 + tu2;

				tu2 = tu1;

				tu1 = tu;

			}
            Console.WriteLine(tu2);
            Console.WriteLine();
            //买东西。小张过元旦发了100元的购物券
            //他要买香皂（5元），牙刷（1.5元），洗发水（20元） 老冰棍1块。
            //要想把100元正好花完，三种都要有，如何买这三样东西？ 
            //如果 剩下的钱 不够买两根老冰棍 怎么买？
            double money=0;
			int count = 0;
			//香皂
			for ( int i = 1; i <= 20; i++ )
				{
				//牙刷
				for ( int j = 1; j < 67; j++ ) 
					{
					//洗发水
					for ( int k = 1; k <= 5; k++ ) 
						{

						/*if ( ( i * 5 ) + ( j * 1.5 ) + ( 20 * k ) <= 100 ) {
							money = 100 - ( (i * 5)  +  (j * 1.5)  +  (20 * k) );
							if ( money < 2 ) {
								Console.WriteLine($"买香皂：{i}个，	买牙刷：{j}个，	买洗发水：{k}瓶，	剩余：{money}元");
							} else if ( money == 0 ) {
								Console.WriteLine($"买香皂：{i}个，	买牙刷：{j}个，	买洗发水：{k}瓶，	剩余：{100 - money}元");
							} 

						}*/
						if ( ( i * 5 ) + ( j * 1.5 ) + ( 20 * k ) <= 100 ) {
								
							money = 100 - ( ( i * 5 ) + ( j * 1.5 ) + ( 20 * k ) );
							if ( money == 0 ) {
								count++;
								Console.WriteLine($"第{count}个方案：买香皂：{i}个，	买牙刷：{j}个，	买洗发水：{k}瓶");
							} else if ( money < 2 ) {
								count++;
								Console.WriteLine($"第{count}个方案：买香皂：{i}个，	买牙刷：{j}个，	买洗发水：{k}瓶，	剩余：{money}元");
							}
							  
						}
					}
				}
			}




















































			//数组，集合，属性（是不是方法???）
			/*
			 
			数组：
				
			集合：

			属性：


			*/



		}
	}
}
