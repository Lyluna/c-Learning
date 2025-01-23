using System.Threading.Channels;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //1.方法要定义在类里面  和main 函数同级的关系
            //2.方法的名字不能重复
            // [访问修饰符] [static] 方法的返回值  方法名字([方法要传入的参数]){
            //方法体
            //}


            //static  加上表示方法是静态的
            //如果说方法没有返回值 写void   如果有返回值  需要return 返回



            //调用方法  静态方法的调用方式   类名.方法名字()；
            //调用方式  如果在同类中 调用可以省略类名
            //Add();
           // string c = Add();
            //Console.WriteLine(c);


            string s = Console.ReadLine();
            int a = IsNumber(s);
            Console.WriteLine(a);




        }


        /*
        public static void Add()
        {
            Console.WriteLine("A");
        }*/
        //带返回值的方法
        /*public static string Add()
        {
            //如果方法写对应的类型  就必须写返回值
            int a = 1;  
            return a+"  ";//return  直接退出方法

        }*/

        public static int IsNumber (string s)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(s);
                    return num;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }




    }
}
