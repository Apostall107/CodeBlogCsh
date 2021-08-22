using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ExtMethods
{
    public  class Square
    {

        public  int X { get; set; } = 0;

        public  int Y { get; set; } = 0;


        public Square()
        {
            this.Area();
        }


        public Square(int x, int y)
        {
            this.Area();
            X = x;
            Y = y;
        }

        public  void Area()
        {

            Console.WriteLine($"area of Square = {X * Y}");

        }

    }


}
