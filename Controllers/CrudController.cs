using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCrudOperation.Models;
using System.Web;
using System.Web.Mvc;


namespace SimpleCrudOperation.Controllers
{
    public class CrudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
