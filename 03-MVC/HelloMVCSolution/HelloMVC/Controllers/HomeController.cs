using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        //Restaurant r = new Restaurant() { Id = 1, nameof = "Chipotle" };
        //Action Methods: methods which handle HTTP requests --> Get, Post, Put, Delete
        [HttpGet]
        [Route("")]
        [Route("Home/index")]
        //public string Index()
        //public JsonResult Index() //can pass as a Json
        //public ObjectResult Index() //can pass as an object
        public IActionResult Index()
        {
            //return "This is the index";
            //return new JsonResult(new { id=1, name="Chipotle"});
            //return new ObjectResult(new { id = 1, name = "Chipotle" });
            return View();
        }
        [HttpGet]
        [Route("Home/index/{id}")]
        public string Index(int? id)
        {
            return id.ToString();
        }

        //Action Methods return types:
        /* 
         IActionResult -> ActionResult -> ViewResult
                                       -> Jsonresult
                                       -> ContentResult
                                       -> PartialViewResult
                                       -> FileResult
                                       -> Ojbectresult
                                       -> RedirectResult
         */

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}
