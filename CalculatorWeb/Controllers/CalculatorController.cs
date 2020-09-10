using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorWeb.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Calculate(double firstvalue, double secondvalue, string operation)
        {
            ServiceReferenceCalculator.CalculatorClient objcalculator = new ServiceReferenceCalculator.CalculatorClient();
            double output = 0;
            string message = string.Empty;
            try
            {
               
                switch (operation)
                {
                    case "Add":
                        output = objcalculator.Addition(firstvalue, secondvalue);
                        break;
                    case "Substract":
                        output = objcalculator.Subtraction(firstvalue, secondvalue);
                        break;
                    case "Multiply":
                        output = objcalculator.Multiplication(firstvalue, secondvalue);
                        break;
                    case "Divide":
                        output = objcalculator.Division(firstvalue, secondvalue);
                        break;
                }


            }
            catch (Exception ex)
            {

                message = ex.Message;
            }

            var data = new { result = output, status = message };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}