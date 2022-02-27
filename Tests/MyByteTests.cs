using System;
using NUnit.Framework;
using Rsa_lab;

namespace MyByteTests
{
    public class AdditionTests
    {
        [Test]
        public void SimpleAddition()
        {
            MyByte myByte = new MyByte(88);
            MyByte rsa1 = new MyByte(12);
            var actual = (myByte+rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullAddition()
        {
            MyByte myByte = new MyByte(0);
            MyByte rsa1 = new MyByte(0);
            var actual = (myByte+rsa1).Decode();
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void NegativeAddition()
        {
            MyByte myByte = new MyByte(-10);
            MyByte rsa1 = new MyByte(-90);
            var actual = (myByte+rsa1).Decode();
            Assert.AreEqual(-100, actual);
        }
    }
    
    public class SubtractionTests
    {
        [Test]
        public void SimpleSubtraction()
        {
            MyByte myByte = new MyByte(110);
            MyByte rsa1 = new MyByte(10);
            var actual = (myByte-rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullSubtraction()
        {
            MyByte myByte = new MyByte(0);
            MyByte rsa1 = new MyByte(0);
            var actual = (myByte-rsa1).Decode();
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void NegativeSubtraction()
        {
            MyByte myByte = new MyByte(-10);
            MyByte rsa1 = new MyByte(-110);
            var actual = (rsa1-myByte).Decode();
            Assert.AreEqual(-100, actual);
        }
    }
    
    public class MultiplicationTests
    {
        [Test]
        public void SimpleMultiplication()
        {
            MyByte myByte = new MyByte(5);
            MyByte rsa1 = new MyByte(20);
            var actual = (myByte*rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullMultiplication()
        {
            MyByte myByte = new MyByte(0);
            MyByte rsa1 = new MyByte(0);
            var actual = (myByte*rsa1).Decode();
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void NegativeMultiplication()
        {
            MyByte myByte = new MyByte(-50);
            MyByte rsa1 = new MyByte(-2);
            var actual = (myByte*rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
    }
    
    public class DivisionTests
    {
        [Test]
        public void SimpleDivision()
        {
            MyByte myByte = new MyByte(300);
            MyByte rsa1 = new MyByte(3);
            var actual = (myByte/rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullDivision()
        {
            try
            {
                MyByte myByte = new MyByte(0);
                MyByte rsa1 = new MyByte(0);
                var actual = (myByte / rsa1).Decode();
                Assert.Fail();
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }
        }
        [Test]
        public void NegativeDivision()
        {
            MyByte myByte = new MyByte(-50);
            MyByte rsa1 = new MyByte(-2);
            var actual = (myByte*rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
    }
    
    public class DivisionWithRemainderTests
    {
        [Test]
        public void SimpleDivisionWithRemainder()
        {
            MyByte myByte = new MyByte(302);
            MyByte rsa1 = new MyByte(3);
            var actual = (myByte%rsa1).Decode();
            Assert.AreEqual(2, actual);
        }
        [Test]
        public void NullDivisionWithRemainder()
        {
            try
            {
                MyByte myByte = new MyByte(0);
                MyByte rsa1 = new MyByte(0);
                var actual = (myByte % rsa1).Decode();
                Assert.Fail();
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }
        }
        [Test]
        public void NegativeDivisionWithRemainder()
        {
            MyByte myByte = new MyByte(-51);
            MyByte rsa1 = new MyByte(-2);
            var actual = (myByte%rsa1).Decode();
            Assert.AreEqual(-1, actual);
        }
    }
    
    public class EqualsTests
    {
        [Test]
        public void Equals()
        {
            MyByte myByte = new MyByte(1);
            MyByte rsa1 = new MyByte(1);
            var actual = myByte==rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NotEquals()
        {
            MyByte myByte = new MyByte(1);
            MyByte rsa1 = new MyByte(2);
            var actual = myByte==rsa1;
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void NullEquals()
        {
            MyByte myByte = new MyByte(0);
            MyByte rsa1 = new MyByte(0);
            var actual = myByte == rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NegativeEquals()
        {
            MyByte myByte = new MyByte(-2);
            MyByte rsa1 = new MyByte(-2);
            var actual = myByte==rsa1;
            Assert.AreEqual(true, actual);
        }
    }
    
    public class NotEqualsTests
    {
        [Test]
        public void NotEquals()
        {
            MyByte myByte = new MyByte(1);
            MyByte rsa1 = new MyByte(2);
            var actual = myByte!=rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NullNotEquals()
        {
            MyByte myByte = new MyByte(0);
            MyByte rsa1 = new MyByte(0);
            var actual = myByte != rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void NegativeNotEquals()
        {
            MyByte myByte = new MyByte(-2);
            MyByte rsa1 = new MyByte(-2);
            var actual = myByte!=rsa1;
            Assert.AreEqual(false, actual);
        }
    }
    
    public class LesserComparisonTests
    {
        [Test]
        public void PositiveComparision()
        {
            MyByte myByte = new MyByte(1);
            MyByte rsa1 = new MyByte(2000);
            var actual = myByte < rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NegativeComparision()
        {
            MyByte myByte = new MyByte(-200);
            MyByte rsa1 = new MyByte(-2);
            var actual = myByte < rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NullComparision()
        {
            MyByte myByte = new MyByte(2);
            MyByte rsa1 = new MyByte(0);
            var actual = myByte < rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void SelfComparision()
        {
            MyByte myByte = new MyByte(2);
            MyByte rsa1 = new MyByte(2);
            var actual = myByte < rsa1;
            Assert.AreEqual(false, actual);
        }
    }
    
    public class BiggerComparisonTests
    {
        [Test]
        public void PositiveComparision()
        {
            MyByte myByte = new MyByte(1);
            MyByte rsa1 = new MyByte(2000);
            var actual = myByte > rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void NegativeComparision()
        {
            MyByte myByte = new MyByte(-200);
            MyByte rsa1 = new MyByte(-2);
            var actual = myByte > rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void NullComparision()
        {
            MyByte myByte = new MyByte(2);
            MyByte rsa1 = new MyByte(0);
            var actual = myByte > rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void SelfComparision()
        {
            MyByte myByte = new MyByte(2);
            MyByte rsa1 = new MyByte(2);
            var actual = myByte > rsa1;
            Assert.AreEqual(false, actual);
        }
    }
}