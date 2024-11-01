﻿using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;   
        }
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User Set(User user)
        {
            _userRepository.Set(user);
            return user;
        }


    }
}
