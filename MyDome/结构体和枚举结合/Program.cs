namespace 结构体和枚举结合 {
	public enum Gonder {
		男,
		女
	}

	public enum Marry {
		未婚,
		已婚,
		离异带俩娃
	}

    public struct Student {
		public string name;
		public int age;
		public Gonder gonder;
		public Marry marry;

		public void StudentMess () {
            Console.WriteLine(name + " " + age + " " + gonder + " " + marry);
        }
    }
    internal class Program {
		static void Main ( string[] args ) {
			Student s = new Student();
			s.name = "xxx";
			s.age = 18;
			s.gonder = Gonder.女;
			s.marry = Marry.离异带俩娃;
			s.StudentMess();
            //Console.WriteLine(s.name+" "+ s.age +" "+ s.gonder + " " + s.marry);
            //Console.WriteLine("Hello, World!");
        }
	}
}
