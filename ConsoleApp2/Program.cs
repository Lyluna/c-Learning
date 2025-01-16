namespace ConsoleApp2
{
    internal class Program
    {
        //全局变量   成员变量
        const int name = 10;
        public static int a;
        public static bool b ;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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

        }
    }
}
