using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DogList.Objects;

namespace DogList.Controllers
{
    public class HomeController : Controller
    {

// HOME AND VIEW ALL ROUTES

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
