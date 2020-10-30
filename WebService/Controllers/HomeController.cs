using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Models;

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataStore dataStore;

        public HomeController(ILogger<HomeController> logger,IDataStore _dataStore)
        {
            _logger = logger;
            dataStore = _dataStore;
        }

        public IActionResult Index()
        {
            var ongoings = dataStore.GetAllOngoing();
            if (ongoings.Count<3)
            {
                var completed = dataStore.GetAllCompleted();
                foreach (var project in completed)
                {
                    ongoings.Add(project);
                }
            }
            
            return View(ongoings);
        }

        public IActionResult Managements()
        {
            return View();
        }
        public IActionResult Ongoing()
        {
            var projects = dataStore.GetAllOngoing();
            return View(projects);
        }
        public IActionResult AllProjects()
        {
            var projects = dataStore.AllProjectDetail();
            return View(projects);
        }
        public IActionResult Upcoming()
        {
            var projects = dataStore.GetAllUpcoming();
            return View(projects);
        }
        public IActionResult Completed()
        {
            var projects = dataStore.GetAllCompleted();
            return View(projects);
        }
        public IActionResult ProjectDetails(string name)
        {
            var project = dataStore.FindProjectDetailByName(name);
            return View(project);
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult AboutUs()
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
    }
}
