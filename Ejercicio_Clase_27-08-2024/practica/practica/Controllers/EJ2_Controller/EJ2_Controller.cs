using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica.EJ2;

namespace practica.Controllers.EJ2_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EJ2_Controller : ControllerBase
    {
        static List<PhotoBook> listaDeLibros = new List<PhotoBook>();
        

        [HttpPost("/albumChico{numPages}")]

        public IActionResult CrearAlbum(int numPages)
        {
            PhotoBook NuevoAlbum;

            if (numPages <= 16)
            {
                NuevoAlbum = new PhotoBook(1);
                listaDeLibros.Add(new PhotoBook(1));
            }
            else {
                NuevoAlbum = new PhotoBook(numPages,1);
                listaDeLibros.Add(new PhotoBook(numPages, 1));
            }


            return Ok("Libro con cantidad de paginas: "+ NuevoAlbum.GetNumPages());
        }


        [HttpPost("/albumGrande")]
        public IActionResult CrearAlbumGrande()
        {
        
            BigPhotoBook NuevoAlbum = new BigPhotoBook(2);          
            listaDeLibros.Add(new BigPhotoBook(2));

            return Ok("Libro con cantidad de paginas: " + NuevoAlbum.GetNumPages());
        }


        [HttpGet("/ConsultaPagina {idLibro}")]
        public IActionResult numeroPaginas(int idLibro) {
            string retVal="";
            foreach (var item in listaDeLibros)
            {
                if (item.ID == idLibro)
                {
                    retVal += "Libro Id:"+item.ID.ToString()+ " Cantidad de paginas: "+item.GetNumPages().ToString()+"\n";
                }
            }

            return Ok(retVal);
        }




    }
}
