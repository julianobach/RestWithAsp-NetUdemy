using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithAspNetUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        // GET api/values/5
        [HttpGet("Sum/{firstnumber}/{secondnumber}")]
        public ActionResult<string> Sum(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        [HttpGet("Subtraction/{firstnumber}/{secondnumber}")]
        public ActionResult<string> Subtraction(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) - ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        [HttpGet("Multiplication/{firstnumber}/{secondnumber}")]
        public ActionResult<string> Multiplication(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) * ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        [HttpGet("Division/{firstnumber}/{secondnumber}")]
        public ActionResult<string> Division(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) / ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        [HttpGet("Median/{firstnumber}/{secondnumber}")]
        public ActionResult<string> Median(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ((ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber))/2);
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        [HttpGet("SquareRoot/{firstnumber}/{secondnumber}")]
        public ActionResult<string> SquareRoot(string number)
        {
            if (IsNumeric(number))
            {
                var sum = Math.Sqrt((double)ConvertToDecimal(number));
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        private decimal ConvertToDecimal(string firstnumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(firstnumber, out decimalValue))
            {
                return decimalValue;
            }

            return 0;

        }

        private bool IsNumeric(string number)
        {
            double dNumber;
            bool isNumber = double.TryParse(number, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out dNumber);

            return isNumber;
        }
    }
}
