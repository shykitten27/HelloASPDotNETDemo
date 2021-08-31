using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("helloworld/")] //all respond to hellowrld CLASS level attribute
    public class HelloController : Controller
    {
        //GET: /<controller>/
        [HttpGet]
        //[Route("/helloworld/")] //no longer needed with class level attribute
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        //GET: /hellow/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")] //curly braces designates the VALUE of the variable, ? designates the value is optional

        //now the Welcome() method below respondst to TWO types of requests, GET and POST
        //GET: /helloworld
        [HttpGet("welcome/{name?}")]
        //POST: /helloworld/
        [HttpPost]
        //[Route("/helloworld/")] //no longer needed with class level attribute
        public IActionResult Welcome(string name = "World") //default parameter value
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
