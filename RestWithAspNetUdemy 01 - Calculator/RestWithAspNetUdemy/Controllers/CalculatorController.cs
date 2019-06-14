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
        [HttpGet("{firstnumber}/{secondnumber}")]
        public ActionResult<string> Sum(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        [HttpGet("{firstnumber}/{secondnumber}")]
        public ActionResult<string> Sub(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) - ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }

            return "Invalid input";
        }

        [HttpGet("{firstnumber}/{secondnumber}")]
        public ActionResult<string> Multiplicacao(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) * ConvertToDecimal(secondnumber);
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
