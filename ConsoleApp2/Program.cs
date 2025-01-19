using System;
using System.Threading.Tasks.Sources;

namespace ConsoleApp2
{
    internal class Program
    {
        //全局变量   成员变量

        const int name = 10;
        public static int a;
        public static bool b;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //基类
            //object a = 10;
            //Console.WriteLine(a);   

            //const int a = 1;//声明时候必须赋一个值 ，常量的值不能改变
            //Console.WriteLine("今年希望是个好年\n可以赚大钱");

            //Console.WriteLine("我今年\"8\"岁");


            //\t   代表制表符即tab   tab为四个空格

            //string a = "我今天\r很开心";
            //string path = "C:\\Users\\叶伟峰\\CPP\\a.txt";
            //File.WriteAllText(path, a);
            //Console.WriteLine("写成功了");

            //Parse有局限性还得考虑字符长度  只能把string类型转换成相对应的类型
            //要转换的类型.parse（要转换的值）
            //string a = "10";
            //int b = int.Parse(a);
            //Console.WriteLine(a);

            //简单类型相互转换
            //int a = 10;
            //double d = 20.6;
            //a = (int)d;//不是四舍五入
            //Console.WriteLine(a);

            //把其他类型转换成string类型 变量.tostring（）   
            //object F12查看源代码

            //+""//转化为string
            //int b = 10;
            //string c = 10 + "";
            //Console.WriteLine(c);   


            //Convert.To要转换的类型（要转换的值）;
            //string a = "10.1";
            //int b = Convert.ToInt32(a);
            //Console.WriteLine(b);

            //int i4 = int.Parse("123.345");
            //Console.WriteLine(i4);

            //double b = 5.51;
            //int a = Convert.ToInt32(b);
            //Console.WriteLine(a);
            //四舍五入  靠近哪个数字就变成哪个数字  10.5就变成10  

            //++  --自加一自减一

            //&& 并且   ||或    ！非   即取反


            //操作数1？操作数2：操作数3
            //？前面的是对的ture  就返回：前面的值，反之就返回：后面的 值

            //int a = 10;
            //int d = a > 10 ? 20 : 30;
            //Console.WriteLine(d);


            //判断闰年   条件被4整除不能被100整除      能被四百整除


            //Console.WriteLine("请输入一个年份");
            //int year = Convert.ToInt32(Console.ReadLine());
            //bool d = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            //Console.WriteLine(d);


            //输入两个整数，并将其分别赋给两个变量，交换它们的值后输出(交换变量)
            //Console.WriteLine("请输入第一个数字");
            // int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("请输入第二个数字");
            //int num2 =  Convert.ToInt32(Console.ReadLine());

            //int num3 = num1;
            //num1 = num2;
            //num2 = num3;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);


            //二进制数左移 右移
            //int a = 4;
            // int c = a << 2;
            //Console.WriteLine(c);

            //if else
            /*int socre = Convert.ToInt32(Console.ReadLine());
            string so = null;
            if (socre >= 90) 
            {
                so = "A";

            }
            else if (socre >= 80)
            {
                so = "B";
            }
            else if (socre >= 70)
            {
                so = "c";
            }
            else if (socre >= 60)
            {
                so = "d";
            }
            else
            {
                so= "e";
            }
            Console.WriteLine(so);
            */

            //switch高级用法
            //表达式 switch{
            //值 => 返回的值 如果没有对应匹配就报错   值与值之间用，（逗号）隔开
            //int a = 10;
            //string result = a switch
            //{
            //    1 => "aa",// => lambda表达式  委托 linq ef
            //    2 => "bb",
            //    11 => "cc",
            //    _ => "xingyang" //弃元
            //};
            //Console.WriteLine(result);



            //switch 常规使用
            //int a = 10;
            //switch (a)
            //{
            //    case 10:
            //        Console.WriteLine(a);
            //        break;
            //    default:
            //        Console.WriteLine(a);
            //        break;


            //}

            //    Console.WriteLine("请输入成绩");
            //    int socre = Convert.ToInt32(Console.ReadLine());
            //    string so = null;
            //    so = socre switch
            //    {
            //        >= 90 and <= 100 => "a",
            //        >= 80 and <= 90 => "b",
            //        >= 70 and <= 80 => "c",
            //        >= 60 and <= 70 => "d",
            //        _ => "e"
            //    };
            //    Console.WriteLine(so);

            //int a = 10;
            //try
            //{
            //    int b = a / 0;

            //}catch (Exception ex)
            //{
            //    Console.WriteLine("当前网络不佳");

            //}finally { Console.WriteLine("fianlly"); }

            /*int a = 0;
            int sum = 0;   
            while (a <= 100) 
            {

                sum += a;
                if (sum > 20)
                {
                    
                    Console.WriteLine(a);
                    break;
                }
                
                ++a;
              
            }*/


            /*int max = 0;
            int min = 100;
            int sum = 0;
            for (int i = 0;i < 7;i++)
            {
                Console.WriteLine("请打分");
                int socre = Convert.ToInt32(Console.ReadLine());

                if (socre > max)
                {
                    max = socre;
                }
                if (socre < min)
                {
                    min = socre;

                }
                sum += socre;
                
            }
            Console.WriteLine(sum - max - min);
            */

            //斐波那契数列
            // 1 1 2 3 5 8 13 21
            int a = 1;
            Console.WriteLine("第一个数字为"+a);
            int b = 1;
            Console.WriteLine("第二个数字为" + b);
            for (int i = 2;i < 12; i++)
            {
                int c = a + b;
                Console.WriteLine($"第{i}个数字为" + c);

                a = b;
                b = c;
            }

            

        }




    }
}
