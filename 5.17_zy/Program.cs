using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._17_zy
{

    enum Weekday {
        unday,Monday=2 ,Tuesday ,Wednesday,Thursday ,Friday,Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region 1.定义一个枚举Weekday，有7个取值：Sunday、Monday 、Tuesday 、Wednesday、Thursday 、Friday、Saturday。将Monday值设为2使用switch通过输入值，输出每一个枚举名称。使用foreach循环遍历枚举Weekday整形数值和名称


            //Console.WriteLine("请输入一个值：");
            //int num = Convert.ToInt32(Console.ReadLine());
            //switch (num)
            //{
            //    case 0:
            //        Console.WriteLine(Weekday.unday);
            //        break;
            //    case 1:
            //        Console.WriteLine(Weekday.Monday);
            //        break;
            //    case 2:
            //        Console.WriteLine(Weekday.Tuesday);
            //        break;
            //    case 3:
            //        Console.WriteLine(Weekday.Wednesday);
            //        break;
            //    case 4:
            //        Console.WriteLine(Weekday.Thursday);
            //        break;
            //    case 5:
            //        Console.WriteLine(Weekday.Friday);
            //        break;
            //    case 6:
            //        Console.WriteLine(Weekday.Saturday);
            //        break;
            //    default:
            //        Console.WriteLine("输入的值有误！");
            //        break;
            //}

            //foreach (int item in Enum.GetValues( typeof(Weekday)))
            //{
            //    Console.Write( item+" ");

            //}


            // foreach (string item in Enum.GetNames(typeof(Weekday)))
            //{
            //    Console.Write(item +" ");
            //}

            //Console.ReadLine();
            #endregion

            Employee em = new Employee();
            em.Id = 1;
            em.Name = "狗蛋";
            em.Age = 15;
            em.Sex = "男";
            em.Phone = "15098452147";
            Console.WriteLine("id为：{0},姓名：{1},年龄：{2},性别：{3}，电话{4}",em.Id,em.Name,em.Age,em.Sex,em.Phone);

            Console.ReadLine();
        }
    }

    #region  2.定义一个结构叫Employee,成员:id,name,age,sex,phone。声明Employee型变量并对其成员赋值，并打印信息

    class Employee {
        private int id;
        private string name;
        private int age;
        private string sex;
        private string phone;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
    }

    #endregion

}
