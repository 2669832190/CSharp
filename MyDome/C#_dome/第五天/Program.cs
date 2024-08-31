namespace 第五天 {
	internal class Program {
		static void Main ( string[] args ) {
			//Console.WriteLine("Hello, World!");
			/*int a = 10;
			int b = a-- + a++ + --a + ++a + --a + a++ + ++a;*/
			//		10	+	9 +	9	+ 10  + 9   +  9  + 11
			//		36+20+11=67
			//Console.WriteLine(b);


			//找出1-1000之间的素数
			Console.WriteLine("1-1000之间的素数有：");
			for ( int i = 2; i <= 1000; i++ ) {
				bool temp = true;
				for ( int j = 2; j <= i / 2; j++ ) {
					if ( i % j == 0 ) {
						temp = false; break;
					}
				}
				if ( temp ) {
					Console.Write($"{i}\t");
				}
			}

			Console.WriteLine();
			Console.WriteLine();

			//控制台输出99乘法表
			for ( int i = 1; i < 10; i++ ) {
				for ( int j = 1; j <= i; j++ ) {
					Console.Write($"{j}×{i}={i * j}\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			//鸡兔同笼	上有 35头	下有	94足
			/*
			 设鸡：x,则兔为：53-x
			 ∵鸡有两只脚	兔有四只脚
			 ∴ 2x + 4*(53-x) = 94
			 
			 



			 */
			//设总共的头为i
			Console.WriteLine("鸡兔同笼	上有 35头	下有 94足");
			int count =  0;
			for ( int i = 1; i < 36; i++ ) {
				if ( 2 * i + 4 * ( 35 - i ) == 94 ) {
					count++;
					Console.Write("一共有" + i + "只鸡，" + ( 35 - i ) + "只兔。");
				}
			}
			Console.WriteLine("综上所述：一共有" + count + "中情况。");


			//只让输入奇数，打印菱形，最多的一行的*的数量等于输入的奇数
			//
			//
			//bool temp = false;
			Console.Write("请输入一个奇数：");
			int num = int.Parse( Console.ReadLine() );
			int UpLineNum = num/2+1;
			int OnLineNum = num/2;

			//这里少对用户输入的数字进行判断是否为奇数！！！




			//菱形上半部分输出
			for ( int i = 1; i <= UpLineNum; i++ ) {
				//
				//
				
				for ( int j = 1; j <= UpLineNum - i; j++ ) {
					//行数-行号
					//num-i
					Console.Write(" ");
				}
				for ( int j = 1; j <= 2 * i - 1; j++ ) {
					//行数-行号
					//num-i
					//2*num-1
					Console.Write("*");
				}

				Console.WriteLine();
			}
			//菱形下半部分输出
			for ( int i = UpLineNum-1; i >= 1; i-- ) {
				//
				//

				for ( int j = 1; j <= UpLineNum - i; j++ ) {
					//行数-行号
					//num-i
					Console.Write(" ");
				}
				for ( int j = 1; j <= 2 * i - 1; j++ ) {
					//行数-行号
					//num-i
					//2*num-1
					Console.Write("*");
				}

				Console.WriteLine();
			}


			Console.WriteLine();
			}
			/*if ( num % 2 != 0 ) {
				
				//打印的行数
                for (int i = 0; i < num; i++)
                {
                    //打印的列数
                    for (int j = 0; j < num; j++)
                    {
                        
                    }
                }
				

				/*

                //打印的行数
                for (int i = 0; i < num/2 ; i++)
                {
					//打印菱形左上角空白区域
					//			9			1
                    for (int j = num ; j > i ; j--)
                    {
						if ( j % 2 != 0&&j!=1) {
                            for (int k = 0; k < length; k++)
                            {
                                
                            }
                            Console.Write("*");
						} else { 
							continue;
						}
					}
                    Console.WriteLine();
                    //打印菱形左上角**区域

                }
				



				//循环上半部分的行数
				/*for (int i = 1; i <= num/2; i++ ) {
					//判断行数是否为奇数，是奇数的时候输出
					if ( i % 2 != 0 ) {
						//当行数为奇数的时候输出为行数的*
						for(int j = 1; j <= i; j++ ) {
                            *//*if ( j % 2 != 0 ) {
								Console.Write("*");
							} else { 
								continue;
							}*//*
                            Console.Write("*");
                        }
					} else { 
						continue;
					}
                    Console.WriteLine();
                }
				//打印上半部分
				/*for (int i = 0; i < num; i++)
                {
					if ( i % 2 != 0 ) {
                        //Console.Write("*");
                        //这里需要进行对每一行打印的次数进行处理
                        //即一行打印多少空白！
                        //7--》3
                        //9--》4
                        *//*for ( int j = 0; j < i ; j++) {
                            Console.Write("*");
                        }*//*
                        for (int j = 1; j <=num ; j++)
                        {
                            
                        }


                        //打印上左半部分的*

                        //for (int k = 0;


                        //打印是上右半部分的*
                        for ( int j = num; j > ; j-- ) {
                            //Console.Write(" ");
                            Console.Write("*");
						}
					} else { 
						continue;
					}
                    Console.WriteLine();
                }

				

            } else {
                Console.WriteLine("输的啥玩意？/白眼");
            }

				/*
				 |     * 
				 |    *** 
				 |   *****
				 |  *******
				 |   *****
				 |    ***
				 |     *
				 | 
				 | 
				 | 
				 | 
				 
				//行数：num
				//行号
				
			}*/
		}
	}