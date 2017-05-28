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

            WriteReport(output);
        }

        static void WriteReport(List<object> result)
        {
            Console.WriteLine($"Fizz: { CountResults(result, "Fizz") }");
            Console.WriteLine($"Buzz: { CountResults(result, "Buzz") }");
            Console.WriteLine($"FizzBuzz: { CountResults(result, "FizzBuzz") }");
            Console.WriteLine($"Lucky: { CountResults(result, "Lucky") }");
            Console.WriteLine($"Integer: { result.Where(s => s.GetType() == typeof(int)).Count() }");
        }

        static int CountResults(List<object> result, string resultType)
        {
            return result.Where(s => s.ToString() == resultType).Count();
        }
    }
}
