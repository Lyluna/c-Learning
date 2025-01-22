using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3
{
    internal class Program
    {

        //1.定义枚举位置   关键字 enum
        //enum  枚举名字{
        //枚举值
        //枚举值
        //}
        enum gender
        {
            男,
            女
        }
        public struct student 
            {
             public int id ;//加public 为字段
            public int age;
            public string name ;
            public string major;
            public char gender;
               }




        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //一个数如果恰好等于它的因子之和（除自身外），则称该数为完全数
            //int count = 0;
            /*for (int i = 6;i < 1000;i++)
            {
                int sum = 0;
                for (int j = 1;j < i;j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }

                }

                if(sum == i)
                {
                    Console.Write(i+"  ");
                  
                   
                }
                //if (count % 5 == 0) 
                //{
                //    Console.WriteLine();
                //}



            }*/

            //九九乘法表
            /* for (int i = 1;i < 10;i++)
             {
                 for(int j = 1; j <= i; j++)
                 {
                     Console.Write($"{i}*{j}={i*j}  ");
                 }
                 Console.WriteLine();
             }*/

            /*int[]a = { 1, 2, 3 };
            int max = 0;
            int min = a[0];
            for (int i = 0;i < 3;i++)
            {
                Console.WriteLine(a[i]);
                if (a[i]> max)
                {
                    max = a[i];
                }
                if (a[i]< min)
                {
                    min = a[i];
                }
                Console.WriteLine(max);
                Console.WriteLine(min);
            }*/
            //a.length数组名  获取数组的长度

            /*int[]a = { 1, 2, 3 ,4,5,6,7,8,9,10};
            for (int i = a.Length-1; i >=0; i--)
            {
                Console.WriteLine(a[i]);
            }*/

            /*int[] a = new int[12];
            a[0] = 1;
            a[1] = 1;
            for (int i = 2;i < a.Length;i++)
            {
                a[i] = a[i - 1] + a[i - 2];
                Console.WriteLine(a[i]);
            }*/

            //将一个字符串数组的元素顺序进行反转。{}

            /* string[] a = { "我", "是", "好人" };
             for (int i = 0; i < a.Length/2; i++)
             {
                 /*string c = a[i];
                 a[i] = a[a.Length - 1-i];
                 a[a.Length - 1-i] = c;

                 //变量交换(a[i], a[a.Length - 1 - i]) = (a[a.Length - 1 - i], a[i]);


             }
             for (int i = 0;i < a.Length; i++)
             {
                 Console.WriteLine(a[i]);
             }*/

            //冒泡排序
            /* int[] a = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            for (int i = 1; i < a.Length; i++) 
            {
                for (int j = 0; j < a.Length - 1 ; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        (a[j], a[j+1]) = (a[j+1], a[j]);
                    }
                }
            }
            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine(a[k]);
            }*/



            //int i, k = 2;
            //Console.WriteLine(i);

            /*int sum = 0;
            int[,] a = new int[5, 5];
            //Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = 1;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a[i,j]+"  ");
                    if (i == j || i + j == 4)
                    {
                        int c = a[i, j];
                        sum += c;

                    }
                }
                Console.WriteLine();
            }           
        
            Console.WriteLine(sum);*/




            /*int count = 1;
            int[,] a = new int[5, 5];
            //Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = count;
                    count++;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(a[i, j] + "  ");

                }
                Console.WriteLine();
            }*/


            /*int[,] a = new int[4, 4];
            int max = 0;
            int count = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = count;
                    if (a[i, j] > max)
                    {
                        max = a[i, j];

                    }
                    count++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (a[i, j] == max)
                    {
                        Console.WriteLine(i+1);
                        Console.WriteLine(j+1);
                    }
                   
                }
            }
            Console.WriteLine(max);*/

            // 什么是枚举  作用增加代码的可能性
            //   规范  定义一种规范
            //枚举名  变量名字
            /* gender a;
             a = gender.男;
             Console.WriteLine(a);*/

            //枚举  访问修饰符
            //访问修饰符   public  公开的  当前的东西在哪里都可以访问

           
        }
    }
}