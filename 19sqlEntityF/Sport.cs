using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19sqlEntityF
{
    public class Sport
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int MinPlayersQuantity { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

    }
}
