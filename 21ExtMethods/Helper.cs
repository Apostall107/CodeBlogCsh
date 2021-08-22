using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ExtMethods
{
    public static class Helper
    {

        public static void IncreaseSidesBy(this Square x, int y)
        {

            x.X += y;
            x.Y += y;
            x.Area();

        }
        public static void DoubleSides(this Square x)
        {

            x.X *= 2;
            x.Y *= 2;
            x.Area();

        }

        public static void MyIntExt(this int x)
        {

            Console.WriteLine($"this int is: {x}");  

        }

        public static void InterFaceExt(this IEnumerable enumerator)
        {

            Console.WriteLine("ill call GetType()");
            Console.WriteLine(enumerator.GetType()); 
        
        }


    }
}
