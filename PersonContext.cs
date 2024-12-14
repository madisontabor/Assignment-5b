using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{

public class PersonContext : DbContext
        {
            public DbSet<Person> People { get; set; }

            protected override void OnConfiguring(
                    DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseSqlite("Data Source=people.db");
        }
    
}
