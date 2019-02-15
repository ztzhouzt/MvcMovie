using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "------this is Welcome--------";
        }
        public IActionResult Other(string Name,int NumTimes=1)
        {
            ViewData["Message"] = "Hello " + Name;
            ViewData["NumTimes"] = NumTimes;
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            return View();
        }
    }
}