using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {   
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 2nd number");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("enter operator numbers");
            char op = char.Parse(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = x + y;
                    Console.WriteLine(result);
                    break;

                case '-':
                    result = x - y;
                    Console.WriteLine(result);
                    break;

                case '*':
                    result = x * y;
                    Console.WriteLine(result);
                    break;

                case '/':
                    result = x / y;
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }

        }
    }
}
