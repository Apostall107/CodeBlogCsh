using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Lesson
{
    class Program
    {

        // Создать Анонимный тип, Tuple и ValueTuple значения.
        // ValueTuple использовать в качестве аргумента метода и 
        // в качестве возвращаемого значения.



        public static (int, string, int) MyTupleMethod()
        {


            return (1, "123", 2);
        
        }


        static void Main(string[] args)
        {

            var product = new
            {
                Name = "Potato",
                Energy = 100
            };

            Console.WriteLine(product);
            Console.WriteLine(product.Energy);
            Console.WriteLine(product.Name);


            Tuple<int, string> tuple = new Tuple<int, string>(1, "123");

            Console.WriteLine($"item 1 :{tuple.Item1}  item2: {tuple.Item2}");

            var valueTuple = (MyInt:5, MyDouble: 5.0, MyStr: "123");
            Console.WriteLine($"{valueTuple}:  MyInt{valueTuple.MyInt}   MyDouble{valueTuple.MyDouble}    MyStr{valueTuple.MyStr}");
            valueTuple.MyInt = 55;
            valueTuple.MyDouble = 55;
            valueTuple.MyStr = "123456789";
            Console.WriteLine($"{valueTuple}:  MyInt{valueTuple.MyInt}   MyDouble{valueTuple.MyDouble}    MyStr{valueTuple.MyStr}");


            var methodData = MyTupleMethod();



        }







    }
}
