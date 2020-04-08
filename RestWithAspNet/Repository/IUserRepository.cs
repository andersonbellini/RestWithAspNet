using RestWithAspNet.Model;
using System.Collections.Generic;

namespace RestWithAspNet.Repository
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
        
    }
}
