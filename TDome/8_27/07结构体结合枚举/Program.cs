using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07结构体结合枚举
{
    //性别
    public enum Gender
    {
        男,
        女
    }

    //婚否
    public enum Marry
    {
        未婚,
        已婚,
        离异带俩娃
    }

    //学生的个人信息
    public struct Student
    {
        public string _name;
        public Gender _gender;
        public int _age;
        public Marry _marry;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //学生信息
            Student stu1;
            stu1._name = "王恩楚";
            stu1._gender = Gender.女;
            stu1._age = 18;
            stu1._marry = Marry.未婚;

            Console.WriteLine(stu1._marry);
        }
    }
}
