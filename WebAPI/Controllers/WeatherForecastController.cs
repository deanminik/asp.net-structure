using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet] //Notation
        public IEnumerable<string>Get(){
            string[] nombres = new []{ "fabian, rolando, maria"};
            return nombres;
        }  
    }
}
