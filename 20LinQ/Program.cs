using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20LinQ
{
    class Program
    {

        static Random rnd = new Random();

        // Домашнее задание
        // В вашей предметной области реализовать работу с коллекциями данных
        // с помощью LINQ. Попробовать все операции
        static void Main(string[] args)
        {

            var products = new List<Product>();
            var products2 = new List<Product>();


            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(50, 60)
                };
                products.Add(product);
            }

            dynamic selectedProducts = products.Select(p => p.Energy > 55);

            Console.WriteLine("Select: >55 \n");
            foreach (var p in selectedProducts)
            {

                Console.WriteLine(p);
            
            }


            

            selectedProducts = products.Where(p => p.Energy > 55);

            Console.WriteLine("\nWhere:   >55 \n");
            foreach (var p in selectedProducts)
            {

                Console.WriteLine(p);

            }



            selectedProducts = products.OrderByDescending(p => p.Energy);

            Console.WriteLine("\n OrderByDescending:  \n");
            foreach (var p in selectedProducts)
            {

                Console.WriteLine(p);

            }

            selectedProducts = products.OrderBy(p => p.Energy).ThenBy(p => p.GetHashCode());

            Console.WriteLine("\n OrderBy Eneggy ThenBy  GetHashCode: \n");
            foreach (var p in selectedProducts)
            {

                Console.WriteLine(p);

            }



            for (var i = 0; i < 10; i++)
            {
                var product2 = new Product()
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(500, 600)
                };
                products2.Add(product2);
            }



            selectedProducts = products.Join(products2,
                                                                  p => p , 
                                                                  p2 => p2 ,  
                                                                  (p, p2) => new {  Name = p.Name , Energy = p2.Energy });

            Console.WriteLine("\n Join: \n");
            foreach (var p in selectedProducts)
            {

                Console.WriteLine(p);

            }


            selectedProducts = products.All(p => p.Energy > 55);

            Console.WriteLine("\n All > 55: \n");

                Console.WriteLine(selectedProducts);



            selectedProducts = products.Any(p => p.Energy > 55);

            Console.WriteLine("\n Any > 55 : \n");

                Console.WriteLine(selectedProducts);




            Product test = new Product();

            selectedProducts = products.Contains(test);

            
            Console.WriteLine("\n Contains: \n");

                Console.WriteLine(selectedProducts);
            



            selectedProducts = products.GroupBy(p => p.Energy > 55).Select(g => new { Energy = g.Key , Count = g.Count()  });

            Console.WriteLine("\n GroupBy: >55  + Select  \n");
            foreach (var p in selectedProducts)
            {

                Console.WriteLine(p);

            }

            selectedProducts = products.ToLookup(p => p.Energy > 55).Select(g => new { Energy = g.Key, Count = g.Count() } );

            Console.WriteLine("\n ToLookup: \n");

            foreach (var p in selectedProducts)
            {

                Console.WriteLine(p);

            }



            selectedProducts = products.Sum(x => x.Energy);

            Console.WriteLine("\n sum Energy: \n");

                Console.WriteLine(selectedProducts);

            selectedProducts = products.ElementAt(2);

            Console.WriteLine("\n  ElementAt 2: \n");

            Console.WriteLine(selectedProducts);
            
            Console.Read();

        }
    }
}
