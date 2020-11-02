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

        [HttpGet("/management")]
        public IActionResult Managements()
        {
            return View();
        }
        
        [HttpGet("/ongoing")]
        public IActionResult Ongoing()
        {
            var projects = dataStore.GetAllOngoing();
            return View(projects);
        }
        
        [HttpGet("/all-projects")]
        public IActionResult AllProjects()
        {
            var projects = dataStore.AllProjectDetail();
            return View(projects);
        }
        
        [HttpGet("/upcoming")]
        public IActionResult Upcoming()
        {
            var projects = dataStore.GetAllUpcoming();
            return View(projects);
        }
        
        [HttpGet("/completed")]
        public IActionResult Completed()
        {
            var projects = dataStore.GetAllCompleted();
            return View(projects);
        }
        
        [HttpGet("/project/{name}")]
        public IActionResult ProjectDetails(string name)
        {
            var project = dataStore.FindProjectDetailByName(name);
            return View(project);
        }
        
        [HttpGet("/contract-us")]
        public IActionResult ContactUs()
        {
            return View();
        }
        
        [HttpGet("/about-us")]
        public IActionResult AboutUs()
        {
            return View();
        }
        
        [HttpGet("/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("/error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
