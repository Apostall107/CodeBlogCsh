using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace _25_Lesson
{
    class Program
    {

        // Исследовать рефлексию: Реализовать получение свойств, классов, методов
        // Создать свой собственный атрибут.
        // Использовать свой собственный атрибут в классе.

        static void Main(string[] args)
        {

            Photo photo = new Photo()
            {

                Name = "firstPhoto.png",
                Path = $@"E/firstPhoto.png"

            };

            var type = typeof(Photo);

            var attributes = type.GetCustomAttributes(true);

            foreach (var att in attributes)
            {
                Console.WriteLine(attributes);
            }


            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name + " " + property.Attributes );


                var attrs = property.GetCustomAttributes(false);

                if (attrs.Any(a => a.GetType() == typeof(CoordinatesAttribute)))
                {

                    Console.WriteLine($"{property.PropertyType} - {property.Name} - has attr." );
                
                }

            }




            Console.Read();
        }



    }

}
