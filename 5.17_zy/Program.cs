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

            //Employee em = new Employee();
            //em.Id = 1;
            //em.Name = "狗蛋";
            //em.Age = 15;
            //em.Sex = "男";
            //em.Phone = "15098452147";
            //Console.WriteLine("id为：{0},姓名：{1},年龄：{2},性别：{3}，电话{4}",em.Id,em.Name,em.Age,em.Sex,em.Phone);

            //Console.ReadLine();


            #region 2. 将一个字符串数组的元素的顺序进行反转。{“3”,“a”,“8”,“haha”} {“haha”,“8”,“a”,“3”}。  要求： (1) 使用反序输出  (2) 使用交换反转 ：第i个和第length - i - 1个进行交换。


            //string[] arr = { "3","a","8","hahah"};
            //  Array.Reverse(arr);
            //foreach (string item in arr)
            //{
            //    Console.Write(item+" ");
            //}

            //for (int i = 0; i < arr.Length/2; i++)
            //{
            //    string temp = arr[i];
            //    arr[i] = arr[arr.Length - 1 - i];
            //    arr[arr.Length - 1 - i] = temp;
            //}

            //foreach (string item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.ReadKey();
            #endregion
            #region 10. 使用编程方式实现，1-2+3-4+5-6……+n的值。m值由控制台输入。

            // Console.WriteLine("请输入一个数字：");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <=num; i++)
            //{
            //    if (i%2==0)
            //    {
            //        sum -= i;
            //    }
            //    if (i%2 !=0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("结果为：{0}",sum);

            //Console.ReadKey();
            #endregion

            #region   11.输入一个整形数组，例如: int[] a = new int[8] { 5, 2, 1, 7, 9, 12, 13, 6 };要求：1.使用控制台输入数据。    2.最大的一个数与第一个元素交换，最小的一个数与最后一个元素交换。最后输出数组。

            //Console.WriteLine("你想输入几个数字：");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[num];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("请输入第{0}个数字：", i + 1);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int max = arr[0];
            //int min = arr[0];
            //int temp = arr[0];
            //int temp1 = arr[0];
            //int a=0;
            //int b=0;
            //for (int i = 0; i <arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //        a=i;

            //    }
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //        b=i;
            //    }
            //}



            //temp1 = arr[arr.Length - 1];
            //arr[arr.Length - 1] = arr[b];
            //arr[b] = temp1;

            //temp = arr[0];
            //arr[0] = arr[a];
            //arr[a] = temp;

            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}


            //Console.ReadKey();







            #endregion

            #region 12. 有n个人围成一圈，顺序排号。从第一个人开始报数（从1到3报数），凡报到3的人退出圈子，问最后留下的是原来第几号的那位。


            Console.WriteLine ("请输入排成一圈的人数：");
            int n = Convert.ToInt32(Console.ReadLine());
            bool[] arr = new bool[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            } 

            int leftCount = n;
            int countNum = 0;
            int index = 0;
            while (leftCount > 1)
            {
                if (arr[index] == true)
                {
                    countNum++;
                    if (countNum == 3)
                    {
                        countNum = 0;
                        arr[index] = false;
                        leftCount--;
                    }
                }
                index++;
                if (index == n)
                {
                    index = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == true)
                {
                    Console.WriteLine ("原排在第" + (i + 1) + "位的人留下了。");
                }
            }

            Console.ReadLine();

            #endregion

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
