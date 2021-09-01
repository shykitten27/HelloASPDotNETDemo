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
                "<select name='Language' id='Language - select'>" +
                "<option value=''>--Please choose a language--</option>" +
                "<option value='English'>English</option>" +
                "<option value='French'>French</option>" +
                "<option value='German'>German</option>" +
                "<option value='Japanese'>Japanese</option>" +
                "<option value='Spanish'>Spanish</option>" +
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
        [HttpPost("welcome")]
        //[Route("/helloworld/")] //no longer needed with class level attribute
        public IActionResult Welcome(string name = "World") //default parameter value
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        public IActionResult CreateMessage(string name = "World", string language = "English")
        {
            string greeting = "";

            if (language == "English")
            {
                greeting = "Hello, ";
            }
            else if (language == "French")
            {
                greeting = "Bonjour, ";
            }
            else if (language == "German")
            {
                greeting = "Halo, ";
            }
            else if (language == "Japanese")
            {
                greeting = "Kon'nichiwa, ";
            }
            else
            {
                greeting = "Hola, ";
            }
            return Content("<h1>" + greeting + name + "!</h1>", "text/html");
        }
    }
}