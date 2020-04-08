using RestWithAspNet.Model;
using RestWithAspNet.Model.Base;
using System.Collections.Generic;

namespace RestWithAspNet.Repository.Generic
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> FindByName(string fristName, string lastName);
    }
}
