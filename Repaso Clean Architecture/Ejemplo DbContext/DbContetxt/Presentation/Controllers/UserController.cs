using Application.DTO;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public  class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService) { 
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }


        [HttpPost]
        public IActionResult Set([FromBody] UserDTO usuario)
        {
            return Ok(_userService.Set(usuario));
        }



    }
}
