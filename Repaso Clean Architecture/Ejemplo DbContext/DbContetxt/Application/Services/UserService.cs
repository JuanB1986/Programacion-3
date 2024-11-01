using Application.DTO;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class UserService    {

        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        public List<UserDTO> GetAll()
        {
            List<User> usuarios = _userRepository.GetAll();
            List<UserDTO> listaDTO = new List<UserDTO>();

            foreach (var item in usuarios)
            {
                listaDTO.Add(new UserDTO(item.dni, item.nombre));
            }

            return listaDTO;
        }


        public User Set(UserDTO usuario)
        {
            User user = new User();
            user.nombre = usuario.nombre;
            user.dni = usuario.dni;

            _userRepository.Set(user);   
            return user;
        }

    }
}
