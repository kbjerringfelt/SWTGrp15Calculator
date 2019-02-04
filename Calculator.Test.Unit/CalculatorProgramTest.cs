using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorProgram.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private CalculatorProgram.Calculator _calculator;

        [SetUp]
       public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestCase(1.00, 2.00 , 3.00)]
        [TestCase(1.00, 3.00, 4.00)]
        [TestCase(4.00, -2.00, 2.00)]
        [TestCase(-1.00, -2.00, -3.00)]
        public void AddNumbersResult(double a, double b, double c)
        {
            Assert.That(_calculator.Add(a, b), Is.EqualTo(c));
        }
    }
}
