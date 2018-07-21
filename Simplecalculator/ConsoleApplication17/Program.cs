using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
                float a, b, c ;
                Console.WriteLine("Calculator");
            Console.WriteLine("Enter value of a");
           Console.WriteLine("Enter value of b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("add="+c);
            c = a - b;
            Console.WriteLine("Subtraction="+c);
            c = a * b; 
            Console.WriteLine("Multiply="+c);
            c = a / b;
            Console.WriteLine("Division=" + c);
            Console.ReadLine();

        }
    }
}
