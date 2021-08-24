using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Lessons
{
    [Serializable]
    public class Company
    {

        private Random rnd = new Random(DateTime.Now.Millisecond);
        public string Name { get; set; }
        public int Id { get; set; }

        public Company()
        {
            Id = rnd.Next(1, 18);
            Name = $"Smth {rnd}";
        }


        public Company(string name, int id)
        {

            // some checks...


            Name = name;
            Id = id;
        }


        public override string ToString()
        {
            return $"Company {Name} №{Id}.";
        }

    }
}
