using System;
using Binary;
using Calculators;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void TestSum()
        {
            var actual = Calculator.Sum(1, 2);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void TestSum2()
        {
            var actual = Calculator.Sum(100, 2);
            Assert.Equal(102, actual);
        }
        
        [Fact]
        public void TestBinary()
        {
            var binary = new BinaryNumber("101");
            Assert.Equal(5, binary.binaryValue);
        }
        
        [Fact]
        public void TestBinary2()
        {
            var binary = new BinaryNumber("10");
            Assert.Equal(2, binary.binaryValue);
        }

        [Fact]
        public void TestBinary3()
        {
            var binary = new BinaryNumber("1");
            Assert.Equal(1, binary.binaryValue);
        }

        [Fact]
        public void TestBinary4()
        {
            var binary = new BinaryNumber("0");
            Assert.Equal(0, binary.binaryValue);
        }
    }
}
