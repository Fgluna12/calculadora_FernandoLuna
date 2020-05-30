using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calc_FL
{
    public class Operacion
    {
        public double a { get; set; }
        public double b { get; set; }

       public double suma()
        {
            return a + b;
        }
        public double resta()
        {
            return a - b;
        }
        public double multiplicacion()
        {
            return a * b;

        }
        public double division()
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                return Convert.ToDouble(e);
            }
        }
    }
}