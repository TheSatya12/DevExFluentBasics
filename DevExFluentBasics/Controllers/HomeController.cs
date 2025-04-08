using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExFluentBasics.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevExFluentBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult StaticGrid()
        {
            var employees = new List<Employee>();
            try
            {
                employees = new List<Employee>
                {
                    new Employee {Id=1,FirstName="Satya",LastName = "Dalayi",Position="Software Engineer",HireDate=new DateTime(2022,1,15)},
                    new Employee {Id=2,FirstName="Datya",LastName="Salayi",Position="UI/UX",HireDate=new DateTime(2024,3,21)},
                    new Employee { Id = 3, FirstName = "Bob", LastName = "Williams", Position = "Project Manager", HireDate = new DateTime(2023, 3, 1) },
                    new Employee { Id = 4, FirstName = "Eve", LastName = "Brown", Position = "UI/UX Designer", HireDate = new DateTime(2022, 9, 10) },
                    new Employee { Id = 5, FirstName = "Charlie", LastName = "Davis", Position = "QA Engineer", HireDate = new DateTime(2024, 2, 25) },
                    new Employee { Id = 6, FirstName = "Grace", LastName = "Miller", Position = "Marketing Specialist", HireDate = new DateTime(2023, 11, 5) },
                    new Employee { Id = 7, FirstName = "David", LastName = "Wilson", Position = "Sales Representative", HireDate = new DateTime(2022, 4, 12) },
                    new Employee { Id = 8, FirstName = "Sophia", LastName = "Moore", Position = "Technical Lead", HireDate = new DateTime(2021, 8, 18) },
                    new Employee { Id = 9, FirstName = "Henry", LastName = "Taylor", Position = "Business Analyst", HireDate = new DateTime(2024, 1, 3) },
                    new Employee { Id = 10, FirstName = "Olivia", LastName = "Anderson", Position = "Database Administrator", HireDate = new DateTime(2023, 7, 30) }

                };
            }
            catch (Exception ex)
            {
               _logger.LogError(ex.Message);
            }
            return View(employees);
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View();
        }
    }
}
