using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestViewComponent.ViewModels;

namespace TestViewComponent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            NoticiaViewModel model = new NoticiaViewModel();
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
