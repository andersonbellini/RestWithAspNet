using System.Collections.Generic;
using RestWithAspNet.Model;
using RestWithAspNet.Model.Context;
using System;
using System.Linq;

namespace RestWithAspNet.Repository.Implementattions
{
    public class UserRepositoryImpl : IUserRepository
    {

        private MySQLContext _context;

        public UserRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        // Método responsável por retornar uma pessoa
        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(u => u.Login.Equals(login));
        }


    }
}
