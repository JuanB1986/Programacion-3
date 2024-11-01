using Domain.Entities;
using Domain.Interfaces;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context) { 
            _context = context;
        }

        public List<User> GetAll() { 
            return _context.Users.ToList();
        }

        public User Set(User user) { 
        
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

    }
}
