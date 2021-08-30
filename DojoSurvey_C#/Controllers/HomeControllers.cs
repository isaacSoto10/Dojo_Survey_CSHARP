using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("survey/create")]
        public IActionResult Create(Survey survey)
        {
            System.Console.WriteLine("NewUser is being Called");
            if(ModelState.IsValid)
            {
                return RedirectToAction("method", survey);
            }
            else
            {
                return View("Index");
            }
        }
        

        [HttpGet]
        [Route("method")]
        public IActionResult Method(Survey survey)
        {
            return View(survey);
        }
    }
}