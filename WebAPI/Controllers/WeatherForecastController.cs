using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dominio;
namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly CoursesOnlineContext context;
       public WeatherForecastController(CoursesOnlineContext _context){
           //CoursesOnlineContext = name of the class that I want to inject 
           this.context = _context;
       }

       [HttGet]
        public IEnumerable<Course>Get(){
           return context.Course.ToList();
        }
    }
}
