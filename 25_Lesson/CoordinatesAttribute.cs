using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Lesson
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CoordinatesAttribute : Attribute
    {


        public int X { get; set; } = 0;

        public int Y { get; set; } = 0;

        public CoordinatesAttribute()
        {
        }

        public CoordinatesAttribute(int x, int y)
        {

            // some check...


            X = x;
            Y = y;
        }


        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }



    }
}
