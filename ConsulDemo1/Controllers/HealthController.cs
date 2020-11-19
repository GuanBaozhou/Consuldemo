using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConsulDemo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("Index")]
        public string Index()
        {
            
            return "ok";
        }
    }
}
