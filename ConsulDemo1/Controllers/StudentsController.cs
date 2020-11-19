using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ConsulDemo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class StudentsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public StudentsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {


            List<string> listnew = new List<string>
        {
            "Api:value1",
            "Api:value2",
            "Api:value3",
            "Api:value4",
           _configuration["port"],
            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")
        };
            return listnew;
        }

        // GET: api/Students/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            List<string> listnew = new List<string>
        {
            "Api:value1",
            "Api:value2",
            "Api:value3",
            "Api:value4",
           _configuration["port"],
            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")
        };
            return listnew[id];
        }
    }
}
