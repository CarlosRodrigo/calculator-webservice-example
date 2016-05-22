using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorExample.Business
{
    public class Minus : ICalculate
    {
        public int Calculate(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}