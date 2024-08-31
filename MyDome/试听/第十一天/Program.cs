using System.Security.Cryptography.X509Certificates;

namespace 第十一天 {
	#region 枚举
	//public enum Aa { 
	//	男,
	//	女,
	//	abcde
	//}
	public enum Water1 {
		农夫山泉,
		净含量 = 550,
		id = 560509,
		湖北省,
		外星人电解质水,
		净含量1 = 500,
		id1 = 922365,
		安徽省

	}
	
    #endregion

    #region 结构体

    //结构体的作用是 一次性的帮助我们声明 多个用于存储值的 字段
    //只需声明一次，后续需要使用时直接赋值
    //使用之前需要先进行声明对象
    //字段 和 变量 的区别：
    //变量在运行期间只能存一个值
    //字段可以存储多个值 一般会以 "_" 开头 


    //public struct Bb {
    //	//放变量（属性）
    //	public int _age;
    //	public string _name;
    //	public double _price;
    //}

    public struct Water{
		public Water1 name;
		public int NetContent;
		public int Id;
		public Water1 Yieldly;
    }



    #endregion
    internal class Program {
		static void Main ( string[] args ) {
			Water WaterOne;
			WaterOne.name = Water1.农夫山泉;
			WaterOne.NetContent = (int)Water1.净含量;
			WaterOne.Id = (int)Water1.id;
			WaterOne.Yieldly = Water1.湖北省;

			Water WaterTwo;
			WaterTwo.name = Water1.外星人电解质水;
			WaterTwo.NetContent = (int)Water1.净含量1;
			WaterTwo.Id = (int)Water1.id1;
			WaterTwo.Yieldly = Water1.安徽省;

            Console.WriteLine($"厂家：{WaterOne.name}，\t净含量：{WaterOne.NetContent}ml，\tid：{WaterOne.Id}，\t生产地：{WaterOne.Yieldly}。");
            Console.WriteLine($"厂家：{WaterTwo.name}，\t净含量：{WaterTwo.NetContent}ml，\tid：{WaterTwo.Id}，\t生产地：{WaterTwo.Yieldly}。");
        }





	}

}
