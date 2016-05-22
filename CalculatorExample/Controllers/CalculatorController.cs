using CalculatorExample.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorExample.Controllers
{
    public class CalculatorController : ApiController
    {
        [Route("api/calculator/sum")]
        [HttpGet]
        public int Sum([FromUri]int value1, [FromUri]int value2)
        {
            Calculator calculator = new Calculator(new Plus());

            return calculator.Calculate(value1, value2);
        }

        [Route("api/calculator/minus")]
        [HttpGet]
        public int Minus([FromUri]int value1, [FromUri]int value2)
        {
            Calculator calculator = new Calculator(new Minus());

            return calculator.Calculate(value1, value2);
        }
    }
}
