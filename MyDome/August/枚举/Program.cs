namespace 枚举_ {
	internal class Program {

		enum E_Coff {
			中杯 = 35,
			大杯 = 40,
			超大杯 = 43
		}

		enum E_QQStatus {
			我在线上=0,
			Q我吧,
			离开,
			忙碌,
			请勿打扰,
			隐身,
			离线
		}

		enum E_BossType {
			Normal,
			Boss
		}
		enum E_PlayerType {
			Main,
			Other
		}

		static void Maina ( string[] args ) {

			#region 基本概念
			#region 枚举是什么

			#endregion

			#region 声明枚举 和 声明枚举变量
			//声明枚举 和 声明枚举变量 是两回事
			//声明枚举：声明一个自定义的枚举类型
			//声明枚举变量：使用已经声明过的自定义枚举类型去创建一个枚举变量


			//注释：三杠注释
			///<summary>
			///qq状态
			///</summary>

			//异常捕获
			/*
			try { 
			
			} catch { 
			
			}
			*/
			#endregion

			#region 声明枚举的语法
			/*
			Enum 自定义的枚举类型名（以E或E_开头）{
				这里写自定义枚举项名字,（第一个默认值为0，下面的会依次增加）
				这里写自定义枚举项名字1,
				这里写自定义枚举项名字2
			}

			Enum 自定义的枚举类型名（以E或E_开头）{
				这里写自定义枚举项名字,（第一个默认值为0，下面的会依次增加）
				这里写自定义枚举项名字1,
				这里写自定义枚举项名字2=5,（从这里开始默认值变为5，下次将从5进行累加）
				这里写自定义枚举项名字3,
				这里写自定义枚举项名字4
			}
			*/
			#endregion
			#endregion

			#region 在哪里声明枚举
			//1.在 namespace 语句块中声明
			//2.class 语句块中声明
			//3.struct 语句块中声明
			//注意：枚举不能在函数语句块中声明

			#endregion

			#region 枚举的使用
			//声明枚举变量
			//自定义枚举类型 变量名 = 默认值（自定义的枚举类型.枚举值）；
			E_PlayerType playerType = E_PlayerType.Main;

			if ( playerType == E_PlayerType.Main ) {
				Console.WriteLine("主玩家逻辑");
			} else if ( playerType == E_PlayerType.Other ) {
				Console.WriteLine("其他玩家逻辑");
			}
			//注意：枚举和switch天生一对(声明完枚举变量后直接用switch在条件中写枚举变量名后直接补全case的代码)
			E_BossType monsterType = E_BossType.Boss;
			switch ( monsterType ) {
				case E_BossType.Normal:
					Console.WriteLine("普通怪物逻辑");
					break;
				case E_BossType.Boss:
					Console.WriteLine("Boss逻辑");
					break;
				default:
					break;
			}
			#endregion

			#region 枚举的数据类型
			//1.枚举和int之间的转换		直接强制转换就行
			int i = (int)playerType;
			Console.WriteLine(i);
			//int 转枚举
			playerType = 0;
			//2.枚举和string之间的转换		使用.ToString()
			string str = playerType.ToString();
			Console.WriteLine(str);
			//string 转枚举
			//Parse后 第一个参数：你要转为哪个 枚举类型
			//第二个参数：用于转换的对应的枚举项的字符串（枚举类型中没有的不能转为枚举）
			//转换完毕后 是一个通用的类型 我们需要用括号强转成我们的目标枚举类型

			//字符串转枚举重点面试可能会问到
			playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType) , "Other");
			#endregion

			#region 枚举的作用（总结）

			//在游戏开发中，对象很多时候会有许多的状态
			//比如玩家 有一个动作状态 我们需要用一个变量或者标识 来表示当前玩家处于的是哪种状态
			//综合考虑 可能会使用int 来表示他的状态
			//1 行走		2 待机		3 跑步	......
			

			//如果使用枚举可以帮助我们 清晰的分析状态的含义

			#endregion

			/*
            //定义qq状态，让用户选择一种在线的状态，输入数字转为枚举类型
			Console.WriteLine("请输入一个数字代表您想要使用的QQ登录的状态（状态如下：）");
			Console.WriteLine("0 :" + E_QQStatus.我在线上);
			Console.WriteLine("1 :" + E_QQStatus.Q我吧);
			Console.WriteLine("2 :" + E_QQStatus.离开);
			Console.WriteLine("3 :" + E_QQStatus.忙碌);
			Console.WriteLine("4 :" + E_QQStatus.请勿打扰);
			Console.WriteLine("5 :" + E_QQStatus.隐身);
			Console.WriteLine("6 :" + E_QQStatus.离线);
            Console.Write("请您选择：");
            int input =	int.Parse(Console.ReadLine());
            E_QQStatus e_QQStatus = (E_QQStatus)input;
            switch ( e_QQStatus ) {
				case E_QQStatus.我在线上:
					Console.WriteLine("您选择的在线状态为：" +E_QQStatus.我在线上);
					break;
				case E_QQStatus.Q我吧:
					Console.WriteLine("您选择的在线状态为：" + E_QQStatus.Q我吧);
					break;
				case E_QQStatus.离开:
					Console.WriteLine("您选择的在线状态为：" + E_QQStatus.离开);
					break;
				case E_QQStatus.忙碌:
					Console.WriteLine("您选择的在线状态为："	+ E_QQStatus.忙碌);
					break;
				case E_QQStatus.请勿打扰:
					Console.WriteLine("您选择的在线状态为：" + E_QQStatus.请勿打扰);
					break;
				case E_QQStatus.隐身:
					Console.WriteLine("您选择的在线状态为：" + E_QQStatus.隐身);
					break;
				case E_QQStatus.离线:
					Console.WriteLine("您选择的在线状态为：" + E_QQStatus.离线);
					break;
			}
			*/

			//用户买咖啡，有中杯（35元），大杯（40元），超大杯（43元），选择要购买的类型，打印：购买的类型和money
			Console.WriteLine("欢迎光临星巴克，下面是我们的咖啡类型：");
			Console.WriteLine(E_Coff.中杯 + ":" + (int)E_Coff.中杯);
			Console.WriteLine(E_Coff.大杯 + ":" + (int)E_Coff.大杯);
			Console.WriteLine(E_Coff.超大杯 + ":" + (int)E_Coff.超大杯);

			Console.Write("请输入您选择的咖啡类型：");
			string input = Console.ReadLine();
			E_Coff e_Coff = (E_Coff)Enum.Parse(typeof(E_Coff) , input );
			switch ( e_Coff ) {
				case E_Coff.中杯:
					Console.WriteLine("您购买了" + E_Coff.中杯 + "，花费了" + (int)E_Coff.中杯 + "元");
					break;
				case E_Coff.大杯:
					Console.WriteLine("您购买了" + E_Coff.大杯 + "，花费了" + (int)E_Coff.大杯 + "元");
					break;
				case E_Coff.超大杯:
					Console.WriteLine("您购买了" + E_Coff.超大杯 + "，花费了" + (int)E_Coff.超大杯 + "元");
					break;
			}
		}
	}
}
