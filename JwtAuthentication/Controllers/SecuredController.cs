using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthentication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SecuredController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetSecuredData()
        {
            return Ok("You got this data becuase you are registered");
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PostSecuredData()
        {
            return Ok("You got this data beacuse you are a admin");
        }
    }
}
