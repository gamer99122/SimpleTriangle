using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            初階三角形1();
            初階三角形2();




            //Console.Read()，可以讓主控台不會因為執行完(↑上述程式碼)就直接關閉
            Console.Read();
        }


        public static void 初階三角形2()
        {
            Console.WriteLine("初階三角形1:");
            Console.WriteLine("-------------------");

            for (int i = 1; i < 4; i++)
            {
                //第一列
                if (i == 1)
                {
                    //空白
                    for (int j = 1; j < 3; j++)
                    {
                        Console.Write(" ");
                    }
                    //星星*
                    for (int j = 3; j < 4; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                //第二列
                if (i == 2)
                {
                    //空白
                    for (int j = 1; j < 2; j++)
                    {
                        Console.Write(" ");
                    }
                    //星星*
                    for (int j = 2; j < 5; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                //第三列
                if (i == 3)
                {
                    //空白
                    //--------

                    //星星*
                    for (int j = 1; j < 6; j++)
                    {
                        Console.Write("*");
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine();
        }



        public static void 初階三角形1()
        {
            Console.WriteLine("初階三角形:");
            Console.WriteLine("-------------------");

            //第一列的空白
            for (int i = 1; i < 3; i++)
            {
                Console.Write(" ");
            }

            //第一列的星星*
            for (int i = 3; i < 4; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();//換行

            //第二列的空白
            for (int i = 1; i < 2; i++)
            {
                Console.Write(" ");
            }

            //第二列的星星*
            for (int i = 2; i < 5; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();//換行

            //第三列星星不需要空白


            //第三列的星星*
            for (int i = 1; i < 6; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
