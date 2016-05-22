using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorExample.Business
{
    public class Calculator
    {
        private ICalculate calculateStrategy;

        public Calculator(ICalculate strategy)
        {
            calculateStrategy = strategy;
        }

        public int Calculate(int value1, int value2)
        {
            return calculateStrategy.Calculate(value1, value2);
        }
    }
}