using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ExtMethods
{
    class Program
    {

        // Домашнее задание
        // В своей предметной области поработать с методами расширения
        // Создать метод расширения для стандартного типа данных
        // Создать метод расширения для интерфейса

        
        static void Main(string[] args)
        {

            Square square = new Square();

            square.IncreaseSidesBy(5);
            square.IncreaseSidesBy(2);
            square.DoubleSides();


            int i = 32;

            i.MyIntExt();

            List<int> vs = new List<int> { 1, 2, 3, 4, 5, 6, 7 };


                vs.InterFaceExt();
            

            Console.Read( );

        }


    }
}
