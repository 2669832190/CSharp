namespace 面向对象 {
	internal class Program {

		//Math类		数学类
		//Goto		类似html中的锚点，适用于判断条件不正确时可返回到开始，重新判断条件

		#region 面向对象

		//万物皆对象
		//类
		//面向对象的三大特性：
		//封装，	用程序语言来形容对象
		//继承，	复用封装对象的代码；儿子继承父亲，复用现成的代码
		//多态	同样的行为不同的表现，儿子继承父亲的基因但是有不同的行为表现
		//面向对象的七大原则：
		//开闭原则，依赖倒转原则，里氏替换原则，单一职责原则，接口隔离原则，合成复用原则，迪米特法则

		#endregion

		#region 面向对象的封装

		#region 类和对象
		//可以通过类创建出对象
		//关键词class

		//一般声明在namespace语句块中


		/*
		(访问修饰符) class 类名 {
			//一类对象的特征	---	成员变量
			//一类对象的行为	---	成员方法
			//保护的特征		---	成员属性

			//构造函数和析构函数
			//索引器
			//运算符重载
			//静态成员
		}*/


		//这个类是用来形容人类的
		//注意：同一个语句块中的不同类 不能重名
		class Person {
			//一类对象的特征	---	成员变量
			//一类对象的行为	---	成员方法
			//保护的特征		---	成员属性

			//构造函数和析构函数
			//索引器
			//运算符重载
			//静态成员

		}

		#endregion

		#region 成员变量

		//基本规则
		//1.声明在类语句块中
		//2.用来描述对象的特征
		//3.可以是任意变量类型
		//4.数量不做限制
		//5.是否赋值根据需求来定
		//如果要在类中声明一个和自己相同类型的成员变量时，
		//不能对它进行实例化
		#endregion

		#region 访问修饰符
		//public		公共的	自己（内部）和别人（外部）都能访问和使用
		//private		私有的	自己（内部）才能访问和使用 ， 不写访问修饰符时，默认为private
		//protected		保护的	自己（内部）和子类才能访问和使用
		//目前决定类内部的成员 的 访问权限
		#endregion

		#region 成员方法

		#region 成员方法的声明
		//基本概念
		//成员方法用来描述对象的行为
		//1.声明在类语句块中
		//2.是用来描述对象的的行为
		//3.规则和函数声明的规则相同
		//4.受到访问修饰符规则的影响
		//5.返回值参数不做限制
		//6.方法数量不做限制

		//注意：
		//1.成员方法不要加static（静态）关键字
		//2.成员方法 必须实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
		//3.成员方法 受到访问修饰符的影响

		class Person2 {
			public string name;
			public int age;
			public Person2[] friends;
			/// <summary>
			/// 打印姓名，年龄和想说的话
			/// </summary>
			/// <param name="str">用户想要说的话</param>
			public void Speak ( string str ) {
				Console.WriteLine("我的姓名：" + name + "，我的年龄：" + age + "，我想说：" + str + "。");
			}
			/// <summary>
			/// 是否成年
			/// </summary>
			/// <returns>返回是否成年</returns>
			public bool IsAdult () {
				return age >= 18;
			}

			public void AddFriend ( Person2 p ) {
				if ( friends.Length == null ) {
					friends = new Person2[] { p };
				} else {
					Person2[] newFriends = new Person2[friends.Length+1];
					for ( int i = 0; i < friends.Length; i++ ) {
						newFriends[i] = friends[i];
					}
					newFriends[newFriends.Length-1] = p;
					friends = newFriends;
				}
			}
		}
		#endregion

		#region 成员方法的使用

		//main方法中

		#endregion

		#endregion


		#endregion
		static void Main ( string[] args ) {
			//Console.WriteLine("Hello, World!");
			#region 什么是（类）对象

			//基本概念
			//类的声明 和 类对象的声明 是两个概念
			//类的声明 类似 枚举 和 结构体 的声明 ， 类的声明相当于声明了一个自定义变量类型
			//而对象 是 类 创建出来的
			//相当于声明一个指定类变量
			//类创建对象的过程 一般称为实例化对象
			//类对象 都是引用类型的

			#endregion

			#region 实例化对象的基本语法

			/*类名 变量名；
			类名 变量名 = null;
			类名 变量名 = new 类名（）；*/

			#endregion

			#region 实例化对象
			Person p;						//栈内存里有空间但是无值为空，堆内存中无空间
			Person p2 = null;               //栈内存里有空间但是无值为空，堆内存中无空间（即不分配堆内存空间）
			Person p3 = new Person();       //栈内存里有空间有值，值为堆内存中的地址，堆内存中有空间

			#endregion

			#region 成员变量的使用和初始值

			//初始值：
			//值类型来说 数字类型	默认值都是 0
			//char				默认值为 空字符
			//boll类型			默认值为 false
			//引用类型			默认值都为 null
			//可通过 default(变量类型) 来确定变量的初始值（可以是值类型和引用类型）
			//Console.WriteLine(default(int));

			//使用：
			//实例化对象变量名.成员变量 = 值；
			#endregion

			#region 成员方法的使用
			Person2 pp2 = new Person2();
			pp2.name = "xxx";
			pp2.age = 18;
			pp2.Speak ("我爱你");
			if ( pp2.IsAdult() ) {
				pp2.Speak("我要耍朋友");
			}
			#endregion

		}
	}
}
