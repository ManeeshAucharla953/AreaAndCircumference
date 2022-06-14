using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AucharlaVersionE.Models;


//Created by Aucharla Maneesh - 700731564
namespace AucharlaVersionE.Controllers
{
    public class HomeController : Controller
    {
       
        //This method is called on first launch which displays Index page
        public IActionResult Index()
        {
            return View(new AucharlaModel());
        }

        [HttpPost] //Defines the below method is triggered for POST Calls

        //This method is called on click of Submit using Form actionn which displays Results page

        public IActionResult Results(AucharlaModel model) {

            //Check if model state is Valid

            if(ModelState.IsValid)
            {
                //Form submission is success and All validations are success
                return View(model);
            }
            //This case is for model state invalid and form is submitted
            return View("Index",model);

        }

    }
}
