using System.Runtime.Intrinsics.X86;

namespace 第八天 {
    //枚举类型（自定义数据类型）：当！相同！的变量值需要在不同类中使用时，使用枚举提前进行定义，需要赋值时直接调用即可，不用多次定义新的变量
    //枚举一般声明在命名空间里，跟类同级，这样的话该命名空间下所有的命名空间中的类都可以使用
    //格式
    /*
	enum	--->枚举类型的数据类型
	(public) enum 枚举类型的变量名（也是自定义的！数据类型名！） { 
		值1,
		值2，
		...
		值N
	}
	*/
    /*
	enum Aa { 
		男,
		女,
		不男不女
	}
	*/
    //需要调用时，使用枚举类型的变量名加“.”后跟值N
    //调用格式：Aa.男
    //
    struct Water {
		public string Name;
		public int NetContent;
		public int Id;
		public string Yieldly;
	}
	enum Vlaue {
		农夫山泉,
		净含量=550,
		id=560509,
		湖北省
	}
	enum Vlaue1 {
		外星人电解质水,
		净含量=500,
		id=922365,
		安徽省
	};
	
	enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
	enum Color {
		//red = new arr[] {255,0,0},
	}

	internal class Program {
        static void Main ( string[] args ) {
			Water water1;
			water1.Name = Vlaue.农夫山泉.ToString();
			water1.NetContent=(int)Vlaue.净含量;
			water1.Id=(int)Vlaue.id;
			water1.Yieldly = Vlaue.湖北省.ToString();



			Water water2;
			int temp = (int)Vlaue1.外星人电解质水;
			//water2.Name = Vlaue1.外星人电解质水.ToString();
			water2.Name = Enum.GetName(typeof(Vlaue1),temp);
			water2.NetContent = (int)Vlaue1.净含量;
			water2.Id = (int)Vlaue1.id;
			water2.Yieldly = Vlaue1.安徽省.ToString();



			//输出
			Console.WriteLine("厂家："+water1.Name+"	，净含量："+water1.NetContent+"ml	，id为："+water1.Id+"	，生产地："+water1.Yieldly);
			Console.WriteLine("厂家："+water2.Name+"	，净含量："+water2.NetContent+"ml	，id为："+water2.Id+"	，生产地："+water2.Yieldly);


			//数组
			int[] arr = new int[]{ };


            //枚举类型的数组
            Console.WriteLine("输入数字返回星期几：");
			int num = int.Parse(Console.ReadLine());
			if ( num == 7 ) {
				num = 0;
			}
            Console.Write($"{(Days)num}");









			
























            //三元表达式
            //int  a=(int)Aa.不男不女;
            //关键字，结构体












        }










































































		/*上午讲了一个 枚举 enum关键字
		三目运算符：--->		（条件）？语句1：语句2		--->	如果条件正确运行第一个语句，如果条件错误运行第二个语句，也可以用三目运算符嵌套
		！枚举（自定义新的一组数相同的数据类型，同时可以用类似数组下标的方式访问）

		还有一个 叫做 结构体 自行预习
		结构体中存的东西，像一个属性，
		！类似对象（例如定义一个水，水的属性为名字（），净含量（），id（），生产地（）...）
		作业：
		1.将枚举中的值 给到结构体


		2.完全弄明白之后， 预习数组，
		 试着创建枚举类型的数组，
		*/





	}
}
