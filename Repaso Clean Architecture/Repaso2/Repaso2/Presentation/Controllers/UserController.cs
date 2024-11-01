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
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get() {

            return Ok(_userService.GetAll());
        }
        [HttpPost]
        public IActionResult Set([FromBody]User user)
        {
            _userService.Set(user);
            return Ok(user);
        }



    }
}
