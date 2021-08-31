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

        //GET: /hellow/welcome
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")] //curly braces designates the VALUE of the variable, ? designates the value is optional
        public IActionResult Welcome(string name = "World") //default parameter value
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
