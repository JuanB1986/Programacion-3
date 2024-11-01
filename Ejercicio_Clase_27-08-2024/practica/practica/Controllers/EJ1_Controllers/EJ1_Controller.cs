using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica.EJ1;

namespace practica.Controllers.EJ1_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EJ1_Controller : ControllerBase
    {



        /* Acá solo pasamos una lista de strings: {"nombre1", "nombre2"}
         * 
        [HttpPost("/Persona")]
        public string saludar([FromBody] List<string> personas)
        {
            string retVal = "";
            personas.ForEach(nom => retVal += nom);
            return retVal;
        }*/


        [HttpPost("/Persona")]
        public string saludar([FromBody] List<Persona> personas)
        {
            string retVal = "";
            personas.ForEach(nom => retVal += nom.Nombre);
            return retVal;
        }



    }
}
