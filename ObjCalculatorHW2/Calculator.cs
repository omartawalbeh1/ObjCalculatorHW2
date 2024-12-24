using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjCalculatorHW2
{
   public class Calculator
    {
        public Calculator(int x,int y) {
            this.x = x; 
            this.y = y;
        }

        public int x
        {
            get; set;
        }
        public int y
        {
            get; set;
        }

        public int Add()
        {
            return x + y;
        }
        public int subtract()
        {
            return x - y;
        }

        public int multiply()
        {
            return x * y;
        }
        public int divide()
        {
            if ( y == 0)
            {
                Console.WriteLine("Cannot Divided By 0");
            }
            else
            {
  return x / y;
            }
            return 0;
        }







    }
}
