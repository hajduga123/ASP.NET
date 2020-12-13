using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;



namespace WebApplication1.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}