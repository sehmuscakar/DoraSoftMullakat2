using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Diagnostics;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }


        
   

    }
}