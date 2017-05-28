using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealFizzBuzz
{
    public class FizzBuzz
    {
        public object DoFizzBuzz(int i)
        {
            if (i < 1)
                throw new DivideByZeroException();

            if (i.ToString().Contains("3"))
                return "Lucky";

            if (i % 15 == 0)
                return "FizzBuzz";

            if (i % 3 == 0)
                return "Fizz";

            if (i % 5 == 0)
                return "Buzz";
            
            return i;
        }
    }
}
