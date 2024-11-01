using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class UserDTO
    {

        public int dni {  get; set; }
        public string nombre { get; set; }

        public UserDTO(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
    }
}
