using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0, Num2 = 0;

            Console.Write("\n Enter First Number -> ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Second Number -> ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Addition Of " + Num1 + " And " + Num2 + " Is -> " + (Num1 + Num2));
            Console.WriteLine("\n Subtraction Of " + Num1 + " And " + Num2 + " Is -> " + (Num1 - Num2));
            Console.WriteLine("\n Multiplication Of " + Num1 + " And " + Num2 + " Is -> " + (Num1 * Num2));
            Console.WriteLine("\n Division Of " + Num1 + " And " + Num2 + " Is -> " + (Num1 / Num2));
            Console.WriteLine("\n Remender Of " + Num1 + " And " + Num2 + " Is -> " + (Num1 % Num2));
;
            Console.WriteLine("\n Press Any Key To EXIT.");

            Console.ReadKey();
        }
    }
}
