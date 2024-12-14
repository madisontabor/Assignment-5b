using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class PersonContextDataSource : IPersonDataSource
    {
            private readonly PersonContext _context; 

            public PersonContextDataSource()
            {
                _context = new PersonContext();
                _context.People.Load();
            }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People.Local.ToBindingList(); 
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }
    }
