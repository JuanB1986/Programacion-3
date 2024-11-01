using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;


namespace Presentation.Controllers
{
    [Route("api/controller")]
    [ApiController]     //Se necesita instalar la libreria: Microsoft.AspNetCore.Mvc    
    public class PersonaController : ControllerBase
    {

        private readonly PersonaService _personaService;

        public PersonaController(PersonaService personaService)
        {

            _personaService = personaService;

        }

        [HttpGet]
        public ActionResult<List<Persona>> GetPersonas()
        {
            return _personaService.GetPersonas();
        }

        [HttpPost]
        public IActionResult AddPersona([FromRoute] Persona persona)
        {
            _personaService.AddPersona(persona);
            return Ok();
        }


    }
}
