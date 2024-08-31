using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TangShidome {

	internal class 营救公主 {


		static void Main ( string[] args ) {
			#region 控制台基本设置
			//控制台光标隐藏
			Console.CursorVisible = false;
			//控制台大小和画布设置
			//总共的宽是50
			const int AllWidth = 50;
			//玩家移动的高为25
			const int PlayerHeight = 25;
			//提示的高为5
			const int TipsHeight = 5;
			//设置控制台的大小
			Console.SetWindowSize(AllWidth , (PlayerHeight+TipsHeight));
			//设置画布的大小
			Console.SetBufferSize(AllWidth , (PlayerHeight+TipsHeight));
			//设置控制台打印字体的颜色为白色
			Console.ForegroundColor	= ConsoleColor.White;
			#endregion

			#region 多场景选择
			//定义不同场景的变量
			//开始界面的id为0；
			//游戏界面的id为1；
			//结束界面的id为2；
			//通过这个变量进行判断后即可进行不同场景的切换
			int NowSceneId =0;
			
			//游戏不退出就一直循环
			while ( true ) {
				//通过场景变量确认进入哪个场景
				switch ( NowSceneId ) {
					#region 开始界面
					case 0:
						//进入之后先进行清除
						Console.Clear();

						//设置光标位置打印开始界面不变的标题
						Console.SetCursorPosition(AllWidth / 2 - 4, 6);
						Console.Write("营救公主");
						//定义一个是否跳出循环的变量用与解决输入完成后需要切换场景时的跳出
						bool isBeginSceneQuitWhile = false;
						//定义选项的选项卡序号进行确定选择的是哪一个选项
						int BeginSceneIndex = 0;

						//定义循环
						while ( true ) {
							Console.SetCursorPosition(AllWidth / 2 - 4 , PlayerHeight / 2 - 3);
							Console.ForegroundColor = BeginSceneIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
							Console.Write("开始游戏");
							Console.SetCursorPosition(AllWidth / 2 - 4 , PlayerHeight / 2 - 1);
							Console.ForegroundColor = BeginSceneIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
							Console.Write("退出游戏");

							//接收用户输入的字符确定移动的位置
							char input = Console.ReadKey(true).KeyChar;
							switch ( input ) {
								case 'W':
								case 'w':
									BeginSceneIndex = 0;
									break;
								case 'S':
								case 's':
									BeginSceneIndex = 1;
									break;
								case 'J':
								case 'j':
									if ( BeginSceneIndex == 0 ) {
										NowSceneId++;
										isBeginSceneQuitWhile = true;
										break;
									} else {
										Environment.Exit(0);
									}
									break;
							}
							if ( isBeginSceneQuitWhile ) {
								break;
							}
						}
						break;
					#endregion
					#region 游戏界面
					case 1:
						Console.Clear();
						#region 打印红墙
						for ( int i = 0; i < PlayerHeight + TipsHeight; i++ ) {
							Console.ForegroundColor = ConsoleColor.Red;
							if ( i == 0 || i == PlayerHeight - 1 || i == ( PlayerHeight + TipsHeight - 1 ) ) {
								for ( int j = 0; j < AllWidth - 1; j++ ) {
									Console.SetCursorPosition(j , i);
									Console.Write("■");
								}
							} else {
								Console.SetCursorPosition(AllWidth - AllWidth , i);
								Console.Write("■");
								Console.SetCursorPosition(AllWidth - 2 , i);
								Console.Write("■");
							}
						}
						#endregion

						#region Boss,player属性
						char GameingInput;
						Random random = new Random();
						int BossX = 24;
						int BossY = 15;
						int BossHp = 100;
						int BossAtkMin = 5;
						int BossAtkMax = 7;
						int BossAtk = random.Next(BossAtkMin,BossAtkMax);
						int BossHps;
						ConsoleColor BossColor = ConsoleColor.Green;
						char Boss ='■';

						int PlayerX = 4;
						int PlayerY = 5;
						int PlayerHp = 100;
						int PlayerAtkMin = 8;
						int PlayerAtkMax = 12;
						int PlayerAtk = random.Next(PlayerAtkMin,PlayerAtkMax);
						int PlayerHps;
						ConsoleColor PlayerColor = ConsoleColor.Yellow;
						char Player ='●';
						#endregion

						#region Boss,Player位置生成和Player移动
						while ( true ) {
							//生成位置
							Console.SetCursorPosition(BossX , BossY);
							Console.ForegroundColor = BossColor;
                            Console.Write(Boss);
							Console.SetCursorPosition(PlayerX , PlayerY);
							Console.ForegroundColor = PlayerColor;
							Console.Write(Player);

							//获取玩家输入
							GameingInput = Console.ReadKey(true).KeyChar;

							//移动位置
							//清除原来的位置并生成新的位置
							Console.SetCursorPosition(PlayerX , PlayerY);
                            Console.Write("  ");
							switch ( GameingInput ) {
								case 'W':
								case 'w':
									PlayerY--;
									if ( PlayerY < 1 ) {
										PlayerY++;
									} else if (PlayerY == BossY && PlayerX == BossX && BossHp > 0 ) {
										PlayerY++;
									}
									break;
								case 'S':
								case 's':
									PlayerY++;
									if (PlayerY > PlayerHeight - 2 ) {
										PlayerY--;
									}else if (PlayerY == BossY &&PlayerX==BossX && BossHp > 0) {
										PlayerY--;
									}
									break;
								case 'A':
								case 'a':
									PlayerX -= 2;
									if ( PlayerX < 2 ) {
										PlayerX += 2;
									}else if ( PlayerX == BossX && PlayerY == BossY && BossHp > 0 ) {
										PlayerX += 2;
									}
									break;
								case 'D':
								case 'd':
									PlayerX += 2;
									if( PlayerX > AllWidth - 3 ) {
										PlayerX -= 2;
									}else if( PlayerX == BossX && PlayerY == BossY && BossHp > 0 ) {
										PlayerX -= 2;
									}
									break;
								case 'J':
								case 'j':

									break;
							}


						}

						#endregion


						Console.ReadKey(true);
						break;
						#endregion
					#region 结束界面
					case 2:

						break;
					#endregion
				}
			}
			#endregion
		}





		#region 111


		static void Maina ( string[] args ) {
			#region 控制台基本设置
			//控制台的光标
			Console.CursorVisible = false;
			//控制台的大小
			//声明常量确定控制台大小和画布的大小
			const int width = 50;
			const int height = 30;
			Console.SetWindowSize(width , height);
			//控制台的画布
			Console.SetBufferSize(width , height);
			//控制台文字颜色设置
			Console.ForegroundColor = ConsoleColor.White;
			#endregion

			#region 多个场景设置
			//
			//！场景切换！
			//	游戏的最终就是死循环！

			/*while ( true ) { 
				case:
				.
				.
				.
			}*/
			#endregion

			#region 营救公主的项目开始

			//定义不同场景的变量
			//开始界面的id为1；
			//游戏界面的id为2；
			//结束界面的id为3；
			//通过这个变量进行判断后即可进行不同场景的切换
			int NowSceneId = 1;



			bool isBattlefalse = false;

			//通过新的变量进行结束场景的切换
			//0为被怪兽打败（默认为0）
			//1为英雄救美
			int GameOverSceneId=0;


			//定义死循环
			while ( true ) {
				
				//通过对不同场景的选择进入判断
				switch ( NowSceneId ) {
					#region 开始界面
					case 1:
						//清除
						Console.Clear();
						//Console.WriteLine("开始界面场景");
						//Console.ReadKey(true);
						Console.SetCursorPosition(width / 2 - 4 , 8);
						Console.Write("营救公主");
						//定义一个开关解决-------------------------------------------
						bool isQuitWhile = false;
						//定义选项卡的序号，用于选择时进行改变颜色
						//当NowSelectIndex=0时，选择的时开始游戏
						//当NowSelectIndex=1时，选择的时退出游戏
						//同时用于按键选择时改变选项卡的颜色
						int NowSelectIndex = 0;
						//因为是不停的输入去选择是否开始游戏，所以用循环进行不停的输入同时进行不同选项卡时颜色的变化
						while ( true ) {
							Console.SetCursorPosition(width / 2 - 4 , 11);
							//使用三目运算符进行判断选项卡的序号
							Console.ForegroundColor = NowSelectIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
							Console.Write("开始游戏");
							Console.SetCursorPosition(width / 2 - 4 , 13);
							//使用三目运算符进行判断选项卡的序号
							Console.ForegroundColor = NowSelectIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
							Console.Write("退出游戏");
							char input = Console.ReadKey(true).KeyChar;
							switch ( input ) {
								//这里可以进行改进（按W键时也可以选择退出游戏）
								case 'W':
								case 'w':
									NowSelectIndex = 0;
									break;
								case 'S':
								case 's':
									NowSelectIndex = 1;
									break;
								case 'J':
								case 'j':
									if ( NowSelectIndex == 0 ) {
										NowSceneId++;
										isQuitWhile = true;
										break;
									} else {
										Environment.Exit(0);
									}
									break;
							}
							if ( isQuitWhile == true ) {
								break;
							}
						}
						break;
						#endregion

					#region 游戏界面
					case 2:
						//清除
						Console.Clear();
						//Console.WriteLine("游戏界面场景");
						//Console.ReadKey(true);
						/*
						第一阶段：
							不变的红墙
							随机数生成怪兽和玩家的位置(不能超出边界生成)
							玩家的移动（不能超出红墙和不能和怪兽在同一位置）
						第二阶段：
							玩家找到怪兽按J键进行攻击
							不断进行攻击	while if
							显示攻击的血量，剩余血量
						第三阶段：
						攻击结束判断玩家还是怪兽胜利	if
						如果玩家胜利，随机显示公主的位置，通过移动进行救出公主结束	改变 GameOverSceneId 的值为1	，game over英雄救美，回到开始界面，退出游戏
						如果玩家失败，显示game over，回到开始界面，退出游戏进行和开始界面一样的判断，直接跳出case 2
						*/
						Console.ForegroundColor= ConsoleColor.Red;
						for (int i = 0;i < height;i++ ) {
							if (i==0||i==height-6||i==height-1) {
								Console.SetCursorPosition(0,i);
								for (int j = 0; j < height-5; j++ ) {
									Console.Write("■");
								}
							}
							Console.SetCursorPosition(0 , i);
							Console.Write("■");
							Console.SetCursorPosition(width - 2 , i);
							Console.Write('■');
						}

						//boss属性
						int monsterHp = 100;
						int monsterAtkmin = 5;
						int monsterAtkmax = 7;
						int monsterX = 24;
						int monsterY = 15;
						int monsterAtk=0;
						char monster = '■';
						ConsoleColor monsterColor = ConsoleColor.Green;

						//玩家属性
						int playerHp = 100;
						int playerAtkmin = 8;
						int playerAtkmax = 12;
						int playerX = 4;
						int playerAtk=0;
						int playerY = 5;
						char player = '●';
						ConsoleColor playerColor = ConsoleColor.Yellow;

						//战斗属性
						int monsterHps;
						int playerHps;



						char GameingInput;

						/*//随机数生成玩家位置
						Random Player = new Random();
						int playerX =Player.Next(width-48,width-4);
						int playerY =Player.Next(height-29,height-7);
						//x2-46,y1-23
						Console.SetCursorPosition(playerX,playerY);
						Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("●");
						
						int monsterX =Player.Next(width-48,width-4);
						int monsterY =Player.Next(height-29,height-7);
						Console.SetCursorPosition(monsterX , monsterY);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("■");*/

						
						//通过循环进行不断的输入
						while ( true ) {
							//绘制boss位置
							Console.SetCursorPosition(monsterX , monsterY);
							Console.ForegroundColor = monsterColor;
                            Console.Write(monster);

							//绘制玩家位置
							Console.SetCursorPosition(playerX , playerY);
							Console.ForegroundColor = playerColor;
							Console.Write(player);

                            //获取用户输入
                            //Console.WriteLine("111");
                            GameingInput = Console.ReadKey().KeyChar;

							//清除原来玩家的位置
							Console.SetCursorPosition(playerX , playerY);
                            Console.Write("  111");

							//对按键进行判断移动
							switch ( GameingInput ) {
								//移动
								case 'W':
								case 'w':
									playerY--;
									if ( playerX == monsterX && playerY == monsterY && monsterHp > 0 ) {
										playerY++;
									} else if ( playerY < 1 ) {
										playerY++;
									}
									break;
								case 'S':
								case 's':
									playerY++;
									if ( playerX == monsterX && playerY == monsterY && monsterHp > 0 ) {
										playerY--;
									} else if ( playerY > height - 7 ) {
										playerY--;
									}
									break;
								case 'A':
								case 'a':
									playerX -= 2;
									if ( playerX == monsterX && playerY == monsterY && monsterHp > 0 ) {
										playerX += 2;
									} else if ( playerX < 2 ) {
										playerX += 2;
									}
									break;
								case 'D':
								case 'd':
									playerX += 2;
									if ( playerX == monsterX && playerY == monsterY && monsterHp > 0 ) {
										playerX -= 2;
									} else if ( playerX > width - 4 ) {
										playerX -= 2;
									}
									break;
								//战斗
								case 'J':
								case 'j':
									bool istrue = false;
									if ( playerY == monsterY ) {
										if ( playerX == monsterX - 2 || playerX == monsterX + 2 ) {
											Console.SetCursorPosition(2 , 25);
											Console.Write("                          ");
											Console.SetCursorPosition(2 , 25);
											Console.Write("继续按J键进行战斗");
											istrue = true;

										} else {
											Console.SetCursorPosition(2 , 25);
											Console.Write("请确认找到boss后再进行战斗");

										}
									} else if ( playerX == monsterX ) {
										if ( playerY == monsterY - 1 || playerY == monsterY + 1 ) {
											Console.SetCursorPosition(2 , 25);
											Console.Write("                          ");
											Console.SetCursorPosition(2 , 25);
											Console.Write("继续按J键进行战斗");
											istrue = true;
										} else {
											Console.SetCursorPosition(2 , 25);
											Console.Write("请确认找到boss后再进行战斗");
										}
									} else {
										Console.SetCursorPosition(2 , 25);
										Console.Write("请确认找到boss后再进行战斗");
									}

									if ( true ) {
										//清除
										Console.SetCursorPosition(2 , 25);
										Console.Write("                   ");
										//开始战斗提示
										Console.SetCursorPosition(2 , 25);
										Console.Write("开始和Boss战斗，按J键继续");
										Console.SetCursorPosition(2 , 26);
										Console.Write("你的当前血量为：" + playerHp);
										Console.SetCursorPosition(2 , 27);
										Console.Write("Boss的当前血量为：" + monsterHp);
										switch ( GameingInput ) {
											case 'J':
											case 'j':
												Random Battle = new Random();
												monsterAtk = Battle.Next(monsterAtkmin , monsterAtkmax);
												playerAtk = Battle.Next(playerAtkmin , playerAtkmax);
												Console.SetCursorPosition(2 , 26);
												for ( int i = 0; i < width - 4; i++ ) {
													Console.Write(" ");
												}
												Console.SetCursorPosition(2 , 27);
												for ( int i = 0; i < width - 4; i++ ) {
													Console.Write(" ");
												}
												monsterHps = monsterHp - playerAtk;
												playerHps = playerHp - monsterAtk;
												Console.SetCursorPosition(2 , 26);
												Console.Write("你对Boss造成" + playerAtk + "点伤害，Boss剩余血量为" + monsterHps);
												Console.SetCursorPosition(2 , 27);
												Console.Write("Boss对你造成" + monsterAtk + "点伤害，你的剩余血量为" + playerHps);
												monsterHp = monsterHps;
												playerHp = playerHps;
												if ( monsterHp <= 0 ) {
													NowSceneId = 3;
													GameOverSceneId = 1;
													isBattlefalse = true;
													//break;
												}
												break;
											//意外情况处理：开始战斗后移动
											case 'W':
											case 'w':

												break;
											case 'S':
											case 's':
												break;
											case 'A':
											case 'a':
												break;
											case 'D':
											case 'd':
												break;
										}

									}
									
									break;
							}
							if ( isBattlefalse ) {
								break;
							}

							
						}
						break ;
					#endregion

					#region 结束界面
					case 3:
						//清除
						Console.Clear();
						//进入结束界面后的选项卡首选项
						int GameOverSceneIndex = 0;
						//输入的字符
						char GameOverSceneinput;
						//跳出循环的开关
						bool GameOverisQuitWhile;
						//进行判断 GameOverSceneId 的值，决定选择输出的结束界面
						if ( GameOverSceneId == 0 ) {
							#region 惨遭屠杀
							Console.SetCursorPosition(width / 2 - 5 , 8);
							Console.Write("Game Over");
							Console.SetCursorPosition(width / 2 - 4 , 9);
							Console.Write("惨遭屠杀");

							while ( true ) {
								GameOverisQuitWhile = false;
								Console.SetCursorPosition(width / 2 - 6 , 12);
								Console.ForegroundColor = GameOverSceneIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
								Console.Write("回到开始界面");
								Console.SetCursorPosition(width / 2 - 4 , 14);
								Console.ForegroundColor = GameOverSceneIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
								Console.Write("退出游戏");
								GameOverSceneinput = Console.ReadKey(true).KeyChar;
								switch ( GameOverSceneinput ) {
									case 'W':
									case 'w':
										GameOverSceneIndex = 0;
										break;
									case 'S':
									case 's':
										GameOverSceneIndex = 1;
										break;
									case 'J':
									case 'j':
										if ( GameOverSceneIndex == 0 ) {
											NowSceneId = 1;
											GameOverisQuitWhile = true;
											break;
										} else {
											Environment.Exit(0);
										}
										break;

								}
								if ( GameOverisQuitWhile ) {
									break;
								}
							}
							break;
							#endregion

						} else {
							#region 英雄救美
							Console.SetCursorPosition(width / 2 - 5 , 8);
                            Console.Write("Game Over");
							Console.SetCursorPosition(width / 2 - 4 , 9);
							Console.Write("英雄救美");
							while (true) {
								GameOverisQuitWhile = false;
								Console.SetCursorPosition(width / 2 - 6 , 12);
								Console.ForegroundColor = GameOverSceneIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                                Console.Write("回到开始界面");
								Console.SetCursorPosition(width / 2 - 4 , 14);
								Console.ForegroundColor = GameOverSceneIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
								Console.Write("退出游戏");
								GameOverSceneinput = Console.ReadKey(true).KeyChar;
								switch ( GameOverSceneinput ) {
									case 'W':
									case 'w':
										GameOverSceneIndex = 0;
										break;
									case 'S':
									case 's':
										GameOverSceneIndex = 1;
										break;
									case 'J':
									case 'j':
										if ( GameOverSceneIndex == 0 ) {
											NowSceneId = 1;
											GameOverisQuitWhile = true;
											break;
										} else { 
											Environment.Exit(0);
										}
										break;
								}
								if ( GameOverisQuitWhile ) {
									break;
								}
							}
							#endregion
						}
						break;
						#endregion
				}

			}
			#endregion

			/*Console.CursorVisible = false;

			//背景为黑色
			Console.BackgroundColor = ConsoleColor.Black;
			//字体为白色
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetWindowSize(50,30);
			Console.SetBufferSize(50,30);
            //Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition ( 20, 5 );
            Console.Write("XXX营救公主");
			int input = 0;
			while ( true ) {
				

				Console.SetCursorPosition(21 , 7);
				Console.Write("开始游戏");
				Console.SetCursorPosition(21 , 9);
				Console.Write("退出游戏");
				char c = Console.ReadKey(true).KeyChar;
				switch ( c ) {
					case 'W':
					case 'w':
						input = 0;
						if ( input == 0 ) {

							Console.ForegroundColor = ConsoleColor.Red;
							Console.SetCursorPosition(21 , 7);
							Console.Write("开始游戏");
							Console.ForegroundColor = ConsoleColor.White;
							Console.SetCursorPosition(21 , 9);
							Console.Write("退出游戏");
						} else {
							


							Console.ForegroundColor = ConsoleColor.White;
							Console.SetCursorPosition(21 , 7);
							Console.Write("开始游戏");
							Console.ForegroundColor = ConsoleColor.Red;
							Console.SetCursorPosition(21 , 9);
							Console.Write("退出游戏");
						}
						break;
					case 'S':
					case 's':
						input = 1;
						if ( input == 1 ) {


							Console.ForegroundColor = ConsoleColor.White;
							Console.SetCursorPosition(21 , 7);
							Console.Write("开始游戏");
							Console.ForegroundColor = ConsoleColor.Red;
							Console.SetCursorPosition(21 , 9);
							Console.Write("退出游戏");
						} else {


							Console.ForegroundColor = ConsoleColor.Red;
							Console.SetCursorPosition(21 , 7);
							Console.Write("开始游戏");
							Console.ForegroundColor = ConsoleColor.White;
							Console.SetCursorPosition(21 , 9);
							Console.Write("退出游戏");
						}
						break;
				}
			}*/
		}
		#endregion

	}
}
