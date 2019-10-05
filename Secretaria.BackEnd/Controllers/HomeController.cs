using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Secretaria.BackEnd.Controllers
{
    
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger/");
        }
    }
}