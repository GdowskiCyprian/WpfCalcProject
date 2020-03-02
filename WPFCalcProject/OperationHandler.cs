using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalcProject
{
    class OperationHandler
    {
        public double number1 = 0;
        public double number2 = 0;
        public char char1 = '_';

        public double operation()
        {
            if(char1 == '+')
            {
                return number1 + number2;
            }
            else if(char1 == '-')
            {
                return number1 - number2;
            }
            else if(char1 == '*')
            {
                return number1 * number2;
            }
            else if(char1 == '/')
            {
                return number1 / number2;
            }
            else
            {
                return 0;
            }
        }
    }
    
}
