using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext _contexto;

        public UserRepository(ApplicationContext contexto) { 
            _contexto = contexto;
        }

        public List<User> GetAll()
        {
            return _contexto.Users.ToList();
        }

        public User Set(User user)
        {
            _contexto.Add(user);
            _contexto.SaveChanges();
            return user;
        }

    }
}
