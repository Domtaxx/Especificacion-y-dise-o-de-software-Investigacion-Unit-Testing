using NUnit.Framework;
using System.Collections.Generic;

namespace Unit_Testing_in_csharp
{
    public class Tests
    {

        /**
         * This tests are to test the framework and how it operates.
         */
        [Test]
        public void Sum_ShouldAddTwoNumbres()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(4, calc.Sum(1, 3));
        }

        /*
         * The next two test prove the output of a faulty and a "correct" line of code using an isEqual assert
         */

        //Expect a failed test
        [Test]
        public void SumOfList_ShouldAddAllElements()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(10);
            list.Add(4);
            list.Add(3);
            //Using an assert to test the wrong output
            Assert.AreEqual(18, calc.Sum_wrong(list));
        }
        //Expect a succesful test
        [Test]
        public void SumOfList_ShouldAddAllElements_2()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(10);
            list.Add(4);
            list.Add(3);
            //Using an assert to test the right output
            Assert.AreEqual(18, calc.Sum(list));
        }
        /*
         * The next two test prove that even in testing there needs to be precision within the test
         */

        //Expect a failed test, because they are different pointers
        [Test]
        public void SumOfList_ShouldAddAllElements_AreSame_2()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(18);
            list.Add(4);
            list.Add(3);
            Assert.AreSame(26.0, calc.Sum(list));
        }
        //Expect a succesful test, because AreEqual expects to only compare the raw value.
        [Test]
        public void SumOfList_ShouldAddAllElements_AreSame_3()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(18);
            list.Add(4);
            list.Add(3);
            Assert.AreEqual(26, calc.Sum(list));
        }
        /*
         * The next tests are for unit testing the function
         */
        [Test]
        public void SumOfList_ShouldBeDouble()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(18);
            list.Add(4);
            list.Add(3);
            Assert.IsInstanceOf<double>(calc.Sum(list));
        }

        [Test]
        public void SumOfList_ShouldNotBeNull()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(18);
            list.Add(4);
            list.Add(3);
            Assert.IsNotNull(calc.Sum(list));
        }
        [Test]
        public void SumOfList_ShouldAddAllElements_positives()
        {            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(112);
            list.Add(12);
            list.Add(13);
            list.Add(1234);
            Assert.AreEqual(112+12+13+1234, calc.Sum(list));
        }

        [Test]
        public void SumOfList_ShouldAddAllElements_negatives()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(-112);
            list.Add(-12);
            list.Add(-13);
            list.Add(-1234);
            Assert.AreEqual(-112-12-13-1234, calc.Sum(list));
        }

        [Test]
        public void SumOfList_ShouldAddAllElements_mixed()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(112);
            list.Add(-12);
            list.Add(13);
            list.Add(-1234);
            Assert.AreEqual(112 - 12 + 13 - 1234, calc.Sum(list));
        }

        //Subtraction
       
        [Test]
        public void SubtractionOfList_ShouldBeDouble()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(18);
            list.Add(4);
            list.Add(3);
            Assert.IsInstanceOf<double>(calc.Subtraccion(list));
        }

        [Test]
        public void SubtractionOfList_ShouldNotBeNull()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(18);
            list.Add(4);
            list.Add(3);
            Assert.IsNotNull(calc.Subtraccion(list));
        }
        [Test]
        public void SubtractionOfList_ShouldAddAllElements_positives()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(112);
            list.Add(12);
            list.Add(13);
            list.Add(1234);
            Assert.AreEqual(-112 - 12 - 13 - 1234, calc.Subtraccion(list));
        }

        [Test]
        public void SubtractionOfList_ShouldAddAllElements_negatives()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(-112);
            list.Add(-12);
            list.Add(-13);
            list.Add(-1234);
            Assert.AreEqual(112 + 12 + 13 + 1234, calc.Subtraccion(list));
        }

        [Test]
        public void SubtractionOfList_ShouldAddAllElements_mixed()
        {
            Calculator calc = new Calculator();
            List<double> list = new List<double>();
            list.Add(112);
            list.Add(-12);
            list.Add(13);
            list.Add(-1234);
            Assert.AreEqual(-112 + 12 - 13 + 1234, calc.Subtraccion(list));
        }
        

    }
}