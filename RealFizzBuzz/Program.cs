using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var intRange = args.Select(int.Parse).ToArray();
            var fizzBuzz = new FizzBuzz();
            var output = new List<object>();


            for (int i = intRange[0]; i <= intRange[1]; i++)
                output.Add(fizzBuzz.DoFizzBuzz(i));
 
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
