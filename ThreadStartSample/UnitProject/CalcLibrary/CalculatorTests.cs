using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitProject;
 

namespace CalcLibrary
{
   
    [TestFixture]
    public class CalculatorTests  
   {
        private Calculator calculator;
        private int sum;
        
        [SetUp]
        public void SetUp()
        {
           calculator = new Calculator();
            sum = 0;
        }

        [Test]
        [TestCase(2,1,3)]
        //[TestCase(2,1,4)]
        public void addMethod(int a,int b,int sum)
        {
            
            var result = calculator.Add(a, b);

            Assert.That(result, Is.EqualTo(sum));
        }
        [TearDown]
        public void CleanUpMethod()
        {
            sum = 0;
        }

    }
}
