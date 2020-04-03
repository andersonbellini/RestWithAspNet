using RestWithAspNet.Model;
using System.Collections.Generic;

namespace RestWithAspNet.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id); 
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(Person person);
    }
}
