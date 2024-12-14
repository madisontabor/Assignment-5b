using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class PersonListDataSource : IPersonDataSource
    {
        private readonly List<Person> _people;

        public PersonListDataSource()
        {
            _people = new List<Person>
        {
            new Person(1, "Madison Tabor", "123-456-7890"),
            new Person(2, "Jane Austin", "987-654-3210"),
            new Person(3, "Barbera Jean", "555-555-5555")
        };
        }

        public IEnumerable<Person> GetPeople()
        {
            return _people.ToList();
        }

        public void SaveChanges()
        {
           
        }
    }
}
