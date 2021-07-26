using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17AsyncTreads
{
    static public class MyCalculations
    {

        static public void Factorial(int n)
        {

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(3000);
            Console.WriteLine($"Factorial: {result}");

        }


        static public async void FactorialAsync(int n)
        {
            Console.WriteLine("FactorialAsync start"); 
            await Task.Run(() => Factorial(n));              
            Console.WriteLine("FactorialAsync ends");
        }

        static public void PowMyNum(int n)
        {
            int result;
            result = n * n;
            Thread.Sleep(3000);
            Console.WriteLine($"{n}*{n} is {result}");
        }

        static public async void PowMyNumAsync(int n)
        {
            Console.WriteLine("PowMyNumAsync start");
            await Task.Run(() => PowMyNum(n));
            Console.WriteLine("PowMyNumAsync ends");
        }
        




    }
}
