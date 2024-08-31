using System.Drawing;

namespace 结构体 {
	#region 结构体

	#region 结构体概念
	//是一种自定义变量类型 类似枚举，需要自己定义
	//它是数据和函数的集合
	//在结构体中 可以声明各种变量和方法

	//作用：用来表现存在关系的数据集合 比如：学生，动物，人类等等
	#endregion


	#region 结构体基本语法

	//一般写在 namespace 语句块中
	//关键字 struct

	//struct 自定义结构体名（帕斯法命名法）{
	//
	//第一部分	
	//变量
	//
	//第二部分	
	//构造函数（可选）
	//
	//第三部分	
	//函数（可选）
	//
	//}
	#endregion

	#region 实例
	//表现 学生的数据的 结构体
	struct Student1{

		#region 访问修饰符

		//修饰结构体中的变量和方法，是否能被外部使用
		//public 公共的 可以被外部访问
		//private 私有的 只能在内容中使用
		//默认不写为 private

		#endregion

		//变量(在结构体中声明的变量不能初始化)
		//变量类型 可以写任意类型 包括结构体   
		//Student s;	！但是  不能是  自己的结构体 可以是其他的
		public int age;
		public bool sex;
		public int num;
		public  string name;


		//构造函数
		#region 构造函数
		//基本概念：
		//1.没有返回值
		//2.函数名必须和结构体名相同
		//3.必须有参数
		//4.如果声明了构造函数 那么必须在其中对所有变量数据初始化
		//也可以方法重载
		public Student1(int age ,bool sex , int num ,string name ) {
			//新的关键字this
			//代表自己的
			this.age = age;
			this.sex = sex;
			this.num = num;
			this.name = name;
		}
		#endregion


		//函数方法
		//表现这个数据结构体的行为
		//在结构体中的方法  目前不需要加 static 关键字

		public void Speak () {
			//函数中可以直接使用结构体中声明的变量
            Console.WriteLine("我的名字是："+name+"，我的年龄是："+age);
        }
		//可以根据需求 写无数个函数
	}
	#endregion

	#endregion

	#region 结构体作业

	struct Student { 
		string name;
		bool sex;
		int age;
		int classNum;
		string specialized;

		public Student (string name , bool sex , int age , int classNum , string specialized) { 
			this.name = name;
			this.sex = sex;
			this.age = age;
			this.classNum = classNum;
			this.specialized = specialized;
            Console.WriteLine("姓名："+name+"，性别："+sex+"，年龄："+age+"，班级："+classNum+"，专业："+specialized+"。");
        }

	}

	struct Rectangle {
		int rectangleLong;
		int rectangleWidth;

		public Rectangle (int rectangleLong , int rectangleWidth) {
            Console.WriteLine("矩形的长为："+rectangleLong+"，宽为："+rectangleWidth+"，面积为："+rectangleLong * rectangleWidth+"，周长为："+2 * (rectangleLong+rectangleWidth)+"。");
        }
	}
	
	enum Message {
		冲锋,
		假死,
		奥术冲击
	}
	struct player {
		public string[] PlayerOccupations;
		public string PlayerOccupation;
		public string PlayerMessage;
		public string PlayerName;

		public player (string PlayerName) {
			this.PlayerName = PlayerName;
			this.PlayerOccupations = new string[]{ "战士","猎人","法师"};
            Console.Write("请选择玩家职业：");
            for (int i = 0;	i < PlayerOccupations.Length; i++) {
                Console.Write(PlayerOccupations[i]+" ");
            }
            Console.WriteLine();
            this.PlayerOccupation = Console.ReadLine();
			switch ( PlayerOccupation ) {
				case "战士":
					PlayerMessage = Message.冲锋.ToString();
                    break;
				case "猎人":
					PlayerMessage = Message.假死.ToString();
					break;
				case "法师":
					PlayerMessage = Message.奥术冲击.ToString();
					break;
			}
			Console.WriteLine(PlayerOccupation + PlayerName + "释放了" +PlayerMessage);
		}

		public string Playername () {
			Console.Write("请输入玩家姓名：");
			string name = Console.ReadLine();
			return name;
		}

	}

	struct boss { 
		public string BossName;
		public int BossHC;
		public int ATK;
		public string[] BossNames;
		public boss ( int ATK ) {
			this.ATK = ATK;
			BossNames = new string[ 10 ];
			for ( int i = 0; i < BossNames.Length; i++ ) {
				BossName = "小怪兽" + i;
				BossNames[i] = BossName;
			}
			for ( int i = 0; i < BossNames.Length; i++ ) {
				Console.Write(BossNames[i]+" "+ATK+"\t");
            }
		}
		public boss ( int BossHC , int ATK ,int AltmanHC) { 
			this.BossHC = BossHC;
			this.ATK = ATK;
			Console.Write("小怪兽打奥特曼：" + "小怪兽的攻击力为：" + ATK + ",奥特曼剩余血量为：" + ( AltmanHC - ATK ));
		}
	}

	struct Altman {
		public int AltmanHC;
		public int AltmanATK;

		public Altman ( int AltmanHC , int AltmanATK ,int BossHC) { 
			this.AltmanATK = AltmanATK;
			this.AltmanHC = AltmanHC;
            Console.Write("奥特曼打小怪兽："+"奥特曼的攻击力为："+AltmanATK+",小怪兽剩余血量为："+(BossHC-AltmanATK));
        }

	}

	#endregion

	internal class Program {
		static void Main ( string[] args ) {

			#region 结构体的使用
			//声明结构体
			//变量类型 变量名；
			Student1 student1;
			student1.age = 18;
			student1.sex = false;
			student1.num = 001;
			student1.name = "唐老师";
			student1.Speak();

			Student1 student2 = new Student1(18 ,true ,002,"小红");
			student2.Speak();

			#endregion


			#region 结构体练习题

			Student s1 = new Student("小明",true,18,1,"计算机");
			Student s2 = new Student("小红",false,18,1,"短视频");

			Rectangle rectangle = new Rectangle(10,20);

			
            player Player_ = new player();
			player Players = new player(Player_.Playername());


			Random random = new Random();
			boss boss = new boss(random.Next(10,20));
            Console.WriteLine();

            Altman altman = new Altman(100 , 50 , 100);
            Console.WriteLine();
            boss = new boss(100,20,100);
            Console.WriteLine();

            #endregion

            //Console.WriteLine("Hello, World!");
        }
	}
}
