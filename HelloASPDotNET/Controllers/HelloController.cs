using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        //GET: /<controller>/
        [HttpGet]
        [Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<h1>Hello World!</h1>";
            return Content(html, "text/html");
        }
    }
}
