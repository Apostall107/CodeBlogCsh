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
        public static object locker = new object();
        static int N = 30;
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any number: ");
            int n = Int32.Parse(Console.ReadLine());


            MyCalculations.PowMyNumAsync(n);
            MyCalculations.FactorialAsync(n);
            MyCalculations.PowMyNum(n);
            MyCalculations.Factorial(n);

            Console.WriteLine("end of method Main");

            Thread.Sleep(3000);

            Console.WriteLine("Threads without lockers: \n");

            Thread.Sleep(2000);

            Thread t = new Thread(Count);
            Thread t1 = new Thread(Count);
            Thread t2 = new Thread(Count);
            Thread t3 = new Thread(Count);
            Thread t4 = new Thread(Count);



            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.BelowNormal;
            t3.Priority = ThreadPriority.AboveNormal;
            t4.Priority = ThreadPriority.Highest;


            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();


            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Main method thread , intretion {i}");
            }

            Thread.Sleep(3000);


            Console.WriteLine("Threads with locker: \n");

            Thread lockerT   = new Thread(LockerCount);
            Thread lockerT1 = new Thread(LockerCount);
            Thread lockerT2 = new Thread(LockerCount);
            Thread lockerT3 = new Thread(LockerCount);
            Thread lockerT4 = new Thread(LockerCount);



            lockerT1.Priority = ThreadPriority.Lowest;
            lockerT2.Priority = ThreadPriority.BelowNormal;
            lockerT3.Priority = ThreadPriority.AboveNormal;
            lockerT4.Priority = ThreadPriority.Highest;


            lockerT1.Start();
            lockerT2.Start();
            lockerT3.Start();
            lockerT4.Start();



            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Main method thread , intretion {i}");
            }


            Console.ReadLine();

        }

        public static void LockerCount()
        {
            Thread t = Thread.CurrentThread;
            lock (locker)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"Sub locker thread priority {t.Priority}, intretion {i}");

                }
            }
        }
        public static void Count()
        {
            Thread t = Thread.CurrentThread;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Sub thread priority {t.Priority}, intretion {i}");

            }
        }
    }
}
