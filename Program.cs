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
            初階三角形();  
        }
        public static void 初階三角形()
        {
            Console.WriteLine("初階三角形:");


            //第一列的空白
            for (int i = 0; i < 2; i++)
            {
                Console.Write(" ");
            }

            //第一列的星星*
            for (int i = 2; i < 3; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();//換行

            //第二列的空白
            for (int i = 0; i < 1; i++)
            {
                Console.Write(" ");
            }

            //第二列的星星*
            for (int i = 1; i < 4; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();//換行

            //第三列星星不需要空白


            //第三列的星星*
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }

            //Console.Read()，可以讓主控台不會因為執行完(↑上述程式碼)就直接關閉
            Console.Read();
        }

    }
}
