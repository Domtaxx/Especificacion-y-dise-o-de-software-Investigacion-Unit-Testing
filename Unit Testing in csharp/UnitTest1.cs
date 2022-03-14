using NUnit.Framework;
using System.Collections.Generic;

namespace Unit_Testing_in_csharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            Calculator calc = new Calculator();
        }

        [Test]
        public void Test_sum_op()
        {
            Calculator calc = new Calculator();
            
            Assert.AreEqual(4, calc.Sum(1, 3));
        }
        /*
        [Test]
        public void Test_add_all_list()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(10);
            list.Add(4);
            list.Add(3);
            //Using an assert to test the wrong output
            Assert.AreEqual(18, calc.Sum_wrong(list));

            //Using an assert to test the correct output
            Assert.AreEqual(18, calc.Sum(list));
        }
        */
    }
}