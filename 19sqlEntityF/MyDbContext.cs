using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19sqlEntityF
{
    class MyDbContext : DbContext
    {

        public MyDbContext() : base("MyDbConnectionString")
        { 
        }

        public DbSet<Sport> Sports { get; set; }
        
        public DbSet<Team> Teams { set; get; }

    }
}
