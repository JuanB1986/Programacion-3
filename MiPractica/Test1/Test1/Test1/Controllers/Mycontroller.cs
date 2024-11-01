using Microsoft.AspNetCore.Mvc;

namespace Test1.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class Mycontroller : ControllerBase
    {
        public static string variable;

        [HttpPost("post {nombre}")]
        public void metodoHTTPpost(string nombre)
        {
            variable = nombre;
        }

        [HttpGet("variable")]
        public String metodoHTTPGet2()
        {
            return "Hola: " + variable;
        }


        [HttpGet("ruta2")]
        public ActionResult metodoHTTPGet3() {
            var retVal = new {clave = 10,Valor = 122};
            return Ok(retVal);
            //return BadRequest("codigo 404");
        }

    }
}
