using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class MathData
    {
        public double FirstNumber;
        public double SecondNumber;
        public string Operation;

        public MathData(double firstNumber, double secondNumber, string operation)
        {
            FirstNumber= firstNumber;
            SecondNumber= secondNumber;
            Operation= operation;
        }
    }
}
