using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Lesson
{


    public class Photo
    {

        public string Name { get; set; }


        [Coordinates(10, 20)]
        public string Path { get; set; }

        public Photo()
        {
        }

        public Photo(string name, string path)
        {
            Name = name;
            Path = path;
        }



    }

}
