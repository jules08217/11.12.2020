using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Исключение деления на 0
            /*try
            {
                int a = 4;
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("С = {0}", c);
            }
            catch { Console.WriteLine("Деление на 0!"); }*/

            //Условия деление на 0
            int a1 = 4;
            int b1 = Convert.ToInt32(Console.ReadLine());
            if (b1 != 0)
            {
                Console.WriteLine("C == " + (a1 / b1));
            }
            else Console.WriteLine("Деление на 0!");
        }
    }
}
