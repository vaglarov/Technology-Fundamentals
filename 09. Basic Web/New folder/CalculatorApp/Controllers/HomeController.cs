using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }
        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalculateResult();
            if (calculator.RightOperand==0&&calculator.Operator=="/")
            {
                TempData["Error"] = "Can not divide by 0!";
            }
            else
            {
            OldCalculation.CalculatorHistory.Add(calculator);
            }
            return RedirectToAction("Index", calculator);
        }
        [HttpGet]
        public IActionResult History()
        {
            return View(OldCalculation.CalculatorHistory);
        }
    }
}
