using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _24_Lesson
{
    class Program
    {


        // В вашей предметной области создать анонимный метод и 
        // аналогичное лямбда выражение.

        // Использовать делегат, обработчик события и изменять 
        // логику метода путем передачи в качестве аргумента делегата.


        delegate void MyHandler(int x, int y);

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void DisplayRedMessage(String message)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
 
            Console.ResetColor();
        }

        static void Main(string[] args)
        {

            MyHandler areaOfRectangle = delegate (int x  , int y)
            {

                Console.WriteLine( $"Area of rectangle = {x * y}" ); 

            };

            areaOfRectangle(5, 3);

            MyHandler lambdaAreaOfRectangle = (x, y) => Console.WriteLine($"(lambda)Area of rectangle {x*y}");

            lambdaAreaOfRectangle(5, 3);




            Account acc = new Account(100);

            acc.Notify += DisplayMessage;

            acc.Deposit(200);   
            acc.Notify += DisplayRedMessage;
            Console.WriteLine($"Account $ : {acc.Sum}");
            acc.Withdraw(250);  
            acc.Notify -= DisplayRedMessage;
            Console.WriteLine($"Account $ : {acc.Sum}");
            acc.Withdraw(180);  
            Console.WriteLine($"Account $ : {acc.Sum}");


            

            Console.Read();


        }


    }



}
