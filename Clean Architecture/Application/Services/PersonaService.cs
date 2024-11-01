using Domain.Entities;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PersonaService
    {
        private readonly MyDbContext _context;


        public PersonaService(MyDbContext context)
        {
            _context = context;
        }


        public void AddPersona(Persona persona)
        {
            _context.Add(persona);
            _context.SaveChanges();
        }

        public List<Persona> GetPersonas()
        {
            return _context.Personas.ToList();
        }

    }
}
