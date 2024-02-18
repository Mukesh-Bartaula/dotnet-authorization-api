using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{

    public class LoginController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult home()
        {
            return Content("Hello World ");

        }
        [HttpGet]
        [Route("get-json-data")]
        public IActionResult GetJsonData()
        {
            var Users = new { username = "abc@123", password = "123" };
            return Json(Users);
        }

    }
}