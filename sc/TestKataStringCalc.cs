using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace sc
{
    [TestFixture]
   public  class TestKataStringCalc
    {
        [Test]
        public void KataStringCalc_GivenInputOf_EmptyString_ShouldReturn_0()
        {
            // Arrange
            const string input = "";
            const int expected = 0;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected,result);

        }


        [Test]
        public void KataStringCalc_GivenInputOf_1_ShouldReturn_1()
        {
            // Arrange
            const string input = "1";
            const int expected = 1;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected,result);

        }


        [Test]
        public void KataStringCalc_GivenInputOf_1_1_ShouldReturn_2()
        {
            // Arrange
            const string input = "1,1";
            const int expected = 2;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected,result);

        }


        [Test]
        public void KataStringCalc_GivenInputOf_1_2_3_ShouldReturn_6()
        {
            // Arrange
            const string input = "1,2,3";
            const int expected = 6;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void KataStringCalc_GivenInputOf_NewLineDelimiter_ShouldReturn_6()
        {
            // Arrange
            const string input = "1\n2,3";
            const int expected = 6;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void KataStringCalc_GivenInputOf_NewLineDelimiterWithDifferent_ShouldReturn_1()
        {
            // Arrange
            const string input = "1,\n";
            const int expected = 1;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void KataStringCalc_GivenInputOf_WithDifferentDelimiters_ShouldReturn_3()
        {
            // Arrange
            const string input = "//;\n1;2";
            const int expected = 3;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void KataStringCalc_GivenInputOf_NegativeNumbers_ShouldThrowException()
        {
            // Arrange
            const string input = "//;\n1;2;-2";
            const int expected = -3;
            var kataStringCalc = CreateKataStringCounter();

            // Act
            var result = kataStringCalc.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }



        [Test]
        public void KataStringCalc_GivenInputOf_WithDifferentDelimitersAnyLenght_ShouldReturn_6()
        {
            // Arrange
            const string input = "//[***]\n1***2***3";
            const int expected = 6;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }



        [Test]
        public void KataStringCalc_GivenInputOf_WithDifferentDelimitersMultiple_ShouldReturn_6()
        {
            // Arrange
            const string input = "//[*][%]\n1*2%3";
            const int expected = 6;
            var KataStringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        private static KataStringCalc CreateKataStringCounter()
        {
            return new KataStringCalc();
        }

    }
}
