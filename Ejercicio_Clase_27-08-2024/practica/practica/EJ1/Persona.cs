using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica.EJ1
{
    public class Persona
    {
        public string Nombre { get; set; }

        public static string getSaludo(List<Persona> personas)
        {
            string nombres = "";
            personas.ForEach(nombre => nombres += nombre.Nombre);
            return "Hola " + nombres;
        }
    
    }
}
