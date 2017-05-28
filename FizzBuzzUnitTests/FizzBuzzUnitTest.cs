using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealFizzBuzz;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        private FizzBuzz _fizzBuzz;

        [TestInitialize]
        public void Initilize()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void IfGiven1_Expect1()
        {
            var expect = 1;
            var actual = _fizzBuzz.DoFizzBuzz(1);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void IfGiven6_ExpectFizz()
        {
            var expect = "Fizz";
            var actual = _fizzBuzz.DoFizzBuzz(6);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void IfGiven5_ExpectBuzz()
        {
            var expect = "Buzz";
            var actual = _fizzBuzz.DoFizzBuzz(5);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void IfGiven15_ExpectFizzBuzz()
        {
            var expect = "FizzBuzz";
            var actual = _fizzBuzz.DoFizzBuzz(15);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void IfGivenContains3_ExpectLucky()
        {
            var expect = "Lucky";
            var actual = _fizzBuzz.DoFizzBuzz(3);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void IfGivenNumberUnder1_ExpectException()
        {
            _fizzBuzz.DoFizzBuzz(0);
        }
    }
}
