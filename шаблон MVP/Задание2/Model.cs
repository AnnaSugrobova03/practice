using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Model
    {
        public int number1, number2, sum;
        public string label1;

        public string Equal(int n1, int n2)
        {
            number1 = n1;
            number2 = n2;
            switch (label1)
            {
                case "+":
                    return Convert.ToString(number1 + number2);
                case "-":
                    return Convert.ToString(number1 - number2);
                case "*":
                    return Convert.ToString(number1 * number2);
                case "/":
                    return number2 != 0 ? Convert.ToString(number1 / number2) : "error";
                default:
                    return "Недопустимое значение";
            }
        }
    }
}
