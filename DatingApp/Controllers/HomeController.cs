using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : Controller
    {
        // GET api/home
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }
    }
}
