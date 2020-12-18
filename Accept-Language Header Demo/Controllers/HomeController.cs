using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Accept_Language_Header_Demo.Models;
using Accept_Language_Header_Demo.Utilities;

namespace Accept_Language_Header_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Language _language;

        public HomeController(ILogger<HomeController> logger, Language language)
        {
            _logger = logger;
            _language = language;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SayHello([FromServices] Language language)
        {
            return Ok(language.Value);
        }
    }
}
