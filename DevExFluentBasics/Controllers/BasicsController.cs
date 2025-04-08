using Microsoft.AspNetCore.Mvc;

namespace DevExFluentBasics.Controllers
{
    public class BasicsController : Controller
    {
        public IActionResult HardCodedData()
        {
            return View();
        }

        public ActionResult<IEnumerable<Object>> GetMovieRating()
        {
            var data = new[]
            {
                new {Id=201,Movie = "Vikram", Rating = "4/5"},
                new {Id = 202,Movie = "Bahubali", Rating = "4/5"}
            };
            return Ok(data);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
