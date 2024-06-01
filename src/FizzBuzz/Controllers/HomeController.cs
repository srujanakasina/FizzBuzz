using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInputProcessor _inputProcessor;

        public HomeController(ILogger<HomeController> logger
            , IInputProcessor inputProcessor)
        {
            _logger = logger;
            _inputProcessor = inputProcessor;
        }

        public IActionResult Index()
        {
            var inputs = new string[] { "1", "3", "5", "<empty>", "15", "A", "23" };
            var result = _inputProcessor.ProcessInputs(inputs);
            return View(result);
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
    }
}
