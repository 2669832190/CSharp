namespace 字符串的方法属性 {
	internal class Program {
		static void Main ( string[] args ) {
			
			string str ="Hello World";
            Console.WriteLine("例子： " + str);
            //字符串的长度
            Console.WriteLine("以上的字符串的长度为："+ str.Length);
            Console.WriteLine();

            //通过字符串的字符下标访问字符串（只能获取，不能修改）
            Console.WriteLine("获取的索引值为“1”的字符为："+str[1]);
            Console.WriteLine();

            //转换为字符串数组
            char[] arr = str.ToCharArray();
            Console.Write("将以上字符串转化为字符数组：");
            foreach ( char c in arr ) { Console.Write(c+", "); }
            Console.WriteLine("\n");

            //判断字符串的开头是否是指定的内容(区分大小写)
            Console.WriteLine("判断以上字符串是否以“He”开头：" + str.StartsWith("He"));//true
            Console.WriteLine("判断以上字符串是否以“he”开头：" + str.StartsWith("he"));
            Console.WriteLine();
            //判断字符串的结尾是否是指定的内容
            Console.WriteLine("判断以上字符串是否以“ld”结尾：" + str.EndsWith("ld"));//true
            Console.WriteLine("判断以上字符串是否以“lD”结尾：" + str.EndsWith("lD"));
            Console.WriteLine();

            //查找是否包含子字符串，包含返回索引，不包含返回-1
            Console.WriteLine("查找是否包含“Wo”,包含返回索引，不包含返回-1:" + str.IndexOf("Wo"));//6
            Console.WriteLine("查找是否包含“oW”,包含返回索引，不包含返回-1:" + str.IndexOf("oW"));
            Console.WriteLine();
            //查找子字符串最后一次出现的索引，没有时返回-1
            Console.WriteLine("查找是否包含“l”最后出现的位置,返回索引，没有返回-1:" + str.LastIndexOf("l"));//9
            Console.WriteLine("查找是否包含“a”最后出现的位置,返回索引，没有返回-1:" + str.LastIndexOf("a"));
            Console.WriteLine();
            Console.WriteLine();
            //分割字符串
            string time = "2024-08-29";
            Console.WriteLine("例子： " + time);
            //通过某个字符进行分割字符串，以下例子通过’-‘进行分割，分割后保存在字符串数组中
            string[] strs = time.Split('-');
            Console.Write("将以上字符串，通过‘-’字符进行分割字符串并存入字符串的数组中：");
            foreach ( string item in strs ) { Console.Write(item + ", ");}
            Console.WriteLine();
            //
        }
	}
}
