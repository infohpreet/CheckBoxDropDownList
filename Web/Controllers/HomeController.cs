using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel();

            if (!string.IsNullOrWhiteSpace(TempData["SelectedLanguagesCsv"] + string.Empty))
            {
                model.SelectedLanguagesCsv = TempData["SelectedLanguagesCsv"] + string.Empty;
            }

            model.SpokenLanguageViewModel = new CheckBoxDropDownListViewModel
            {
                Items = new Dictionary<string, string>() { { "EN", "English" }, { "NO", "Norwegian" }, { "DK", "Danish" } },
                ControlName = nameof(model.SelectedLanguagesCsv),
                SelectedItemsCsv = model.SelectedLanguagesCsv
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            TempData["SelectedLanguagesCsv"] = model.SelectedLanguagesCsv;

            return RedirectToAction(nameof(Index));
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
