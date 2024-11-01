using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly MyContextDb _contexto;

        public UserRepository(MyContextDb contexto)
        {
            _contexto = contexto;
        }   

        public List<User> GetAll()
        {
            return _contexto.Users.ToList();
        }

        public User Set(User user)
        {
            _contexto.Users.Add(user);
            _contexto.SaveChanges();
            return user;
        }
    }
}
