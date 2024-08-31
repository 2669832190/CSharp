namespace TangShiDome {
	internal class 入门 {
		static void Maina ( string[] args ) {
			//入门
			//
			//
			//
			//
			Console.WriteLine("换行输出语句");
			Console.Write("不换行输出语句");
			Console.ReadLine();//输入语句，回车结束
			Console.ReadKey();//输入语句，只能输入一个字符
			#region //折叠代码
			//折叠代码
			#endregion

			//sizeof获取变量类型所占的内存空间 
			//常量
			//必须初始化，且不可修改值
			//格式： const 数据类型 常量名 = 常量值；
			const string name = "唐老师";
			//常用的转义字符：
			//单引号   \'
			//双引号   \"
			//换行     \n
			//斜杠     \\     --->计算机路径要用到

			//不常用的转义字符
			//制表符         \t
			//光标退格       \b      --->类似删除键
			//空字符         \0      --->基本不用
			//警报音         \a      --->基本不用


			//取消转义字符
			//字符串前加”@“



			char _1 = '李';
			char _2 = '宗';
			char _3 = '桓';
			int a = _1;
			int b = _2;
			int c = _3;
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			//26446
			//23447
			//26707
			//2677
			//222677





			//显示转换（强制转换）
			#region 括号强转
			//括号强转（注意范围和精度问题）
			//变量类型 变量名 = （数据类型）变量
			//
			//
			#endregion

			#region Parse法
			//Parse法
			//将对应字符串中的数字或字符进行转换成对应的数据类型
			//变量类型.Parse法("字符串")
			//注意：字符串必须能够转换成对应的类型 否则报错
			#endregion

			#region Convert法
			//Convert法
			//更准确的将 各个类型之间进行相互转换 精度更高
			//格式：Convert.To目标类型（变量或常量）
			//注意：填写的变量或常量必须正确 否则出错

			//short 时目标类型为  Int16
			//int   时目标类型为  Int32
			//long  时目标类型为  Int64
			//float 时目标类型为  Single
			//bool  时目标类型为  Boolean


			//也可以转换bool类型true为1，false为0
			//字符也可以转，转为阿斯克码
			#endregion

			#region 其他类型转string
			//其他类型转string
			//  当拼接打印时就已经自动调用ToString()
			//  格式：变量.ToString(); 
			#endregion

			#region 总结
			//总共有四种；
			//括号法（强制转换，只能对数值进行转换而且精度不高）
			//Parse法（将字符串中的数值或字符进行转换成对应的数据类型）
			//Convert法（各个类型之间都可以相互转换，精度比括号的高）
			//ToString(其他类型转字符串)
			#endregion

			#region 作业
			char aa = Convert.ToChar(24069);
			Console.WriteLine(aa);
			Console.WriteLine();

			//-------------------------------------

			Console.Write("姓名:");
			string name1 = Console.ReadLine();
			Console.Write("语文:");
			int yuwen = int.Parse(Console.ReadLine());
			Console.Write("数学:");
			int shuxue = int.Parse(Console.ReadLine());
			Console.Write("英语:");
			int yingyu = int.Parse(Console.ReadLine());
			Console.WriteLine("姓名：" + name1 + "，语文:" + yuwen + "分，数学:" + shuxue + "分，英语:" + yingyu + "分。");

			#endregion


			#region 异常捕获
			//通过异常捕获可以避免当代码报错时，造成程序卡死的情况
			//格式：
			//必备部分：
			//	try{
			//	希望进行异常捕获的代码块 将其放入try中
			//	如果try中的代码报错了不会让程序卡死
			//	}
			//	catch{
			//	如果try中的代码出错会执行catch中的代码来捕获异常
			//	catch后也可以加"（Exception e）"	具体的报错跟踪，通过e得到 具体的错误信息
			//	}
			//可选部分：
			//	finally{
			//	最后执行的代码，不管有没有出错，都会执行其中的代码
			//	}
			//注意：异常捕获代码基本结构中 不需要加“；”，在里面写逻辑是每一句代码后要加“；”
			//--------------------
			try {
				Console.WriteLine("请输入数字：");
				string str = Console.ReadLine();
				int i =int.Parse(str);
				Console.WriteLine(i);
			} catch {
				Console.WriteLine("请输入合法的值");
			} finally {
				Console.WriteLine("执行完毕");
			}


			//---------------------------------------------

			try {
				Console.Write("请输入数字：");
				int num = int.Parse(Console.ReadLine());
				Console.WriteLine(num);
			} catch {
				Console.WriteLine("输入错误！");

			}

			try {
				Console.Write("姓名:");
				string name11 = Console.ReadLine();
				Console.Write("语文:");
				int yuwen1 = int.Parse(Console.ReadLine());
				Console.Write("数学:");
				int shuxue1 = int.Parse(Console.ReadLine());
				Console.Write("英语:");
				int yingyu1 = int.Parse(Console.ReadLine());
				Console.WriteLine("姓名：" + name11 + "，语文:" + yuwen1 + "分，数学:" + shuxue1 + "分，英语:" + yingyu1 + "分。");
			} catch {
				Console.WriteLine("输入错误！");

			}

			#endregion


			//字符串拼接
			string str1 =("你好，我是"+"lzh"+",我今年"+18+"岁了");
			Console.WriteLine(str1);
			string str2 =string.Format("你好，我是{0},我今年{1}岁了","lzh",18);
			Console.WriteLine(str2);


			//声明一个自定义的颜色变量
			ConsoleColor aaa = ConsoleColor.Green;
		}
	}
}
