using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test;

namespace Test_WebApi.Controllers
{
    public class HomeController : Controller
    {
        private Class1 objclass = null;
        public HomeController()
        {
            objclass = new Class1();
        }
        public IActionResult Index()
        {
            return Content(objclass.GetMessage());
        }
    }
}