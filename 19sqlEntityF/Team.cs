using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19sqlEntityF
{
    public class Team
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int PlayersQuantity { get; set; }

        public int SportID { get; set; }
        public virtual Sport Sport { get; set; }

    }
}
