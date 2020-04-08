using RestWithAspNet.Model;
using RestWithAspNet.Model.Context;
using RestWithAspNet.Repository.Generic;
using System.Linq;
using System.Collections.Generic;

namespace RestWithAspNet.Business.Implementattions
{
    public class PersonRepositoryImpl : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepositoryImpl(MySQLContext context) : base(context) { }

        public List<Person> FindByName(string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p => p.FirstName.Contains(firstName) && p.LastName.Contains(lastName)).ToList();
            }
            else if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p => p.LastName.Contains(lastName)).ToList();
            }
            else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p => p.FirstName.Contains(firstName)).ToList();
            }
            return _context.Persons.ToList();
        }
    }
}

