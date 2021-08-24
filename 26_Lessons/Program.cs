using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _26_Lessons
{
    class Program
    {
        // В своей предметной области создать сериализаторы 4 типов
        // bin 
        // soap
        // xml 
        // json
        static void Main(string[] args)
        {


            List<Company> companies = new List<Company>();
            List<Worker> workers = new List<Worker>();

            for (int i = 1; i < 10; i++)
            {
                companies.Add(new Company("smth" + i, i));
            }

            for (int i = 1; i < 15; i++)
            {
                Worker worker = new Worker(Guid.NewGuid().ToString().Substring(0, 5), Guid.NewGuid().ToString().Substring(0, 5), i % 100)

                {
                    Company = companies[i % 9]
                };

                workers.Add(worker);
            }


            #region bin

            Console.WriteLine("\nbin");

            BinaryFormatter binFormatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("Company.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fs, companies);
            }

            using (FileStream fs = new FileStream("Company.bin", FileMode.OpenOrCreate))
            {
                List<Company> newCompanies = binFormatter.Deserialize(fs) as List<Company>;

                if (newCompanies != null)
                {
                    foreach (var company in companies)
                    {
                        Console.WriteLine(company);
                    }

                }

            }


            #endregion


            #region Soap


            Console.WriteLine("\nSoap ");
            var soapFormatter = new SoapFormatter();

            using (FileStream fs = new FileStream("Company.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, companies.ToArray());
            }

            using (FileStream fs = new FileStream("Company.soap", FileMode.OpenOrCreate))
            {
                var newCompany = soapFormatter.Deserialize(fs) as Company[];

                if (newCompany != null)
                {
                    foreach (var company in newCompany) 
                    {
                        Console.WriteLine(company);
                    }
                }
            }

            #endregion




            #region xml

            Console.WriteLine("\nxml ");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Company>));


            using (FileStream fs = new FileStream("Company.xml", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fs, companies);
            }

            using (FileStream fs = new FileStream("Company.xml", FileMode.OpenOrCreate))
            {
                List<Company> newCompanies = binFormatter.Deserialize(fs) as List<Company>;

                if (newCompanies != null)
                {
                    foreach (var company in companies)
                    {
                        Console.WriteLine(company);
                    }

                }

            }

            #endregion




            #region json

            Console.WriteLine("\njson");

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Worker>));

            using (FileStream fs = new FileStream("Worker.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, workers);
            }

            using (FileStream fs = new FileStream("Worker.json", FileMode.OpenOrCreate))
            {
                List<Worker> newWorkers = jsonSerializer.ReadObject(fs) as List<Worker>;

                if (newWorkers != null)
                {
                    foreach (var worker in workers)
                    {
                        Console.WriteLine(worker);
                    }

                }


            }


            #endregion








            Console.Read();

        }


    }
}
