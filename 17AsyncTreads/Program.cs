using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17AsyncTreads
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any number: ");
            int n = Int32.Parse(Console.ReadLine());
            

            MyCalculations.PowMyNumAsync(n);
            MyCalculations.FactorialAsync(n);
            MyCalculations.PowMyNum(n);
            MyCalculations.Factorial(n);

                Console.WriteLine( "end of method Main");

            Thread.Sleep(3000);


            

        }
    }
}
