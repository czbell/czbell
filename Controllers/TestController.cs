using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetapp.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TestController : Controller
    {
        [HttpGet]
        public string GetString()
        {
            return "this is test demo.";
        }
    }
}

