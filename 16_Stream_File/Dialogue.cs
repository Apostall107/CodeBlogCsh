using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogCsh
{
    static public class Dialogue
    {

        static public void DialogueWithUser(string fileName)
        {


            while (true)
            {
                string str = "";
                double height = 0, weight = 0;
                    int bmi = 0;
                Console.Clear();
                Console.WriteLine("Choose the option please. \n Press 1 to add info to file. \n Press 2  to read info in file \n Press 3  to exit.");
                var input = Console.ReadKey();
                Console.WriteLine();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        Console.Write("\nEnter your height:");
                        height = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter your weight:");
                        weight = Convert.ToDouble(Console.ReadLine());
                        bmi = Convert.ToInt32(weight / (height / 100 * height / 100));
                        Console.Write($"\nYour BMI is {bmi}.");

                        str = $"\nYour height:{height}cm, weight:{weight}kl, BMI: {bmi}   {DateTime.Now}";

                        Writing.WriteTofile(fileName, str);
                        break;


                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:


                        Reading.ReadFile(fileName);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        Environment.Exit(0);

                        break;
                    default:
                        break;

                }

            }
        }
    }

}

