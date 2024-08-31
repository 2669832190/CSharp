using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05枚举
{
    //枚举的作用？
    //统计所有人的性别
    //有的人统计：男，女     1,0     公,母     ...
    //让统计的性别有一个标准：只能选择男/女

    //enum 声明枚举类型的关键字
    public enum Gender
    {
        //枚举里的项通过逗号分隔,最后一项可以不要逗号
        男,
        女,
        武装直升机,
        沃尔玛塑料袋
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //声明一个枚举类型的变量
            //通过我们刚才创建的枚举类型的名称 作为数据类型使用
            Gender sex;
            sex = Gender.沃尔玛塑料袋;
            Console.WriteLine(sex);
        }
    }
}
