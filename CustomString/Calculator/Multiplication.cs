using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString.Calculator
{
    public class Multiplication : Math
    {
        public void doMultiplication(double number1, double number2)
        {
            this.number1 = number1;
            this.number1 = number2;
            solution = (number1 * number2);
            Console.WriteLine(solution);
        }
    }
}
