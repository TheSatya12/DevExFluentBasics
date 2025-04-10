using DevExFluentBasics.Data;
using DevExFluentBasics.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DevExFluentBasics.Controllers
{
    public class BudgetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BudgetController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetBudgets(DataSourceLoadOptions loadOptions)
        {
            var annualBudgets = _context.AnnualBudgets;
            return DataSourceLoader.Load(annualBudgets, loadOptions);
        }

        [HttpPost]
        public IActionResult InsertBudget([FromBody] AnnualBudget objAnnualBudget)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.AnnualBudgets.Add(objAnnualBudget);
            _context.SaveChanges();

            return Ok(objAnnualBudget);
        }

        [HttpPut]
        public IActionResult UpdateBudget(int key, [FromBody] AnnualBudget objAnnualBudget)
        {
            var entity = _context.AnnualBudgets.Find(key);
            if (entity == null) return NotFound();

            entity.Name = objAnnualBudget.Name;
            _context.SaveChanges();
            return Ok(entity);
        }

        [HttpDelete]
        public IActionResult DeleteBudget(int key)
        {
            var entity = _context.AnnualBudgets.Find(key);
            if (entity == null) return NotFound();

            _context.AnnualBudgets.Remove(entity);
            _context.SaveChanges();
            return Ok();
        }
    }
}
