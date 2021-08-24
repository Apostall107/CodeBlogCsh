using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _26_Lessons
{

    [DataContract]
    public class Worker
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Position { get; set; }


        [DataMember]
        public int Age { get; set; }

        
        [DataMember]
        public Company Company { get; set; }
        
        
        
        public Worker()
        {
        }

        public Worker(string name, string position, int age)
        {
            // some checks...


            Name = name;
            Position = position;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
