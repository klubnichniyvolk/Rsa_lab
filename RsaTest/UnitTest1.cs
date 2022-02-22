using System;
using NUnit.Framework;
using Rsa_lab;

namespace RsaTest
{
    public class AdditionTests
    {
        [Test]
        public void SimpleAddition()
        {
            Rsa rsa = new Rsa(88);
            Rsa rsa1 = new Rsa(12);
            var actual = (rsa+rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullAddition()
        {
            Rsa rsa = new Rsa(0);
            Rsa rsa1 = new Rsa(0);
            var actual = (rsa+rsa1).Decode();
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void NegativeAddition()
        {
            Rsa rsa = new Rsa(-10);
            Rsa rsa1 = new Rsa(-90);
            var actual = (rsa+rsa1).Decode();
            Assert.AreEqual(-100, actual);
        }
    }
    
    public class SubtractionTests
    {
        [Test]
        public void SimpleSubtraction()
        {
            Rsa rsa = new Rsa(110);
            Rsa rsa1 = new Rsa(10);
            var actual = (rsa-rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullSubtraction()
        {
            Rsa rsa = new Rsa(0);
            Rsa rsa1 = new Rsa(0);
            var actual = (rsa-rsa1).Decode();
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void NegativeSubtraction()
        {
            Rsa rsa = new Rsa(-10);
            Rsa rsa1 = new Rsa(-110);
            var actual = (rsa1-rsa).Decode();
            Assert.AreEqual(-100, actual);
        }
    }
    
    public class MultiplicationTests
    {
        [Test]
        public void SimpleMultiplication()
        {
            Rsa rsa = new Rsa(5);
            Rsa rsa1 = new Rsa(20);
            var actual = (rsa*rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullMultiplication()
        {
            Rsa rsa = new Rsa(0);
            Rsa rsa1 = new Rsa(0);
            var actual = (rsa*rsa1).Decode();
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void NegativeMultiplication()
        {
            Rsa rsa = new Rsa(-50);
            Rsa rsa1 = new Rsa(-2);
            var actual = (rsa*rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
    }
    
    public class DivisionTests
    {
        [Test]
        public void SimpleDivision()
        {
            Rsa rsa = new Rsa(300);
            Rsa rsa1 = new Rsa(3);
            var actual = (rsa/rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void NullDivision()
        {
            try
            {
                Rsa rsa = new Rsa(0);
                Rsa rsa1 = new Rsa(0);
                var actual = (rsa / rsa1).Decode();
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
            Rsa rsa = new Rsa(-50);
            Rsa rsa1 = new Rsa(-2);
            var actual = (rsa*rsa1).Decode();
            Assert.AreEqual(100, actual);
        }
    }
    
    public class DivisionWithRemainderTests
    {
        [Test]
        public void SimpleDivisionWithRemainder()
        {
            Rsa rsa = new Rsa(302);
            Rsa rsa1 = new Rsa(3);
            var actual = (rsa%rsa1).Decode();
            Assert.AreEqual(2, actual);
        }
        [Test]
        public void NullDivisionWithRemainder()
        {
            try
            {
                Rsa rsa = new Rsa(0);
                Rsa rsa1 = new Rsa(0);
                var actual = (rsa % rsa1).Decode();
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
            Rsa rsa = new Rsa(-51);
            Rsa rsa1 = new Rsa(-2);
            var actual = (rsa%rsa1).Decode();
            Assert.AreEqual(-1, actual);
        }
    }
    
    public class EqualsTests
    {
        [Test]
        public void Equals()
        {
            Rsa rsa = new Rsa(1);
            Rsa rsa1 = new Rsa(1);
            var actual = rsa==rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NotEquals()
        {
            Rsa rsa = new Rsa(1);
            Rsa rsa1 = new Rsa(2);
            var actual = rsa==rsa1;
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void NullEquals()
        {
            Rsa rsa = new Rsa(0);
            Rsa rsa1 = new Rsa(0);
            var actual = rsa == rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NegativeEquals()
        {
            Rsa rsa = new Rsa(-2);
            Rsa rsa1 = new Rsa(-2);
            var actual = rsa==rsa1;
            Assert.AreEqual(true, actual);
        }
    }
    
    public class NotEqualsTests
    {
        [Test]
        public void NotEquals()
        {
            Rsa rsa = new Rsa(1);
            Rsa rsa1 = new Rsa(2);
            var actual = rsa!=rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NullNotEquals()
        {
            Rsa rsa = new Rsa(0);
            Rsa rsa1 = new Rsa(0);
            var actual = rsa != rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void NegativeNotEquals()
        {
            Rsa rsa = new Rsa(-2);
            Rsa rsa1 = new Rsa(-2);
            var actual = rsa!=rsa1;
            Assert.AreEqual(false, actual);
        }
    }
    
    public class LesserComparisonTests
    {
        [Test]
        public void PositiveComparision()
        {
            Rsa rsa = new Rsa(1);
            Rsa rsa1 = new Rsa(2000);
            var actual = rsa < rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NegativeComparision()
        {
            Rsa rsa = new Rsa(-200);
            Rsa rsa1 = new Rsa(-2);
            var actual = rsa < rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void NullComparision()
        {
            Rsa rsa = new Rsa(2);
            Rsa rsa1 = new Rsa(0);
            var actual = rsa < rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void SelfComparision()
        {
            Rsa rsa = new Rsa(2);
            Rsa rsa1 = new Rsa(2);
            var actual = rsa < rsa1;
            Assert.AreEqual(false, actual);
        }
    }
    
    public class BiggerComparisonTests
    {
        [Test]
        public void PositiveComparision()
        {
            Rsa rsa = new Rsa(1);
            Rsa rsa1 = new Rsa(2000);
            var actual = rsa > rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void NegativeComparision()
        {
            Rsa rsa = new Rsa(-200);
            Rsa rsa1 = new Rsa(-2);
            var actual = rsa > rsa1;
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void NullComparision()
        {
            Rsa rsa = new Rsa(2);
            Rsa rsa1 = new Rsa(0);
            var actual = rsa > rsa1;
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void SelfComparision()
        {
            Rsa rsa = new Rsa(2);
            Rsa rsa1 = new Rsa(2);
            var actual = rsa > rsa1;
            Assert.AreEqual(false, actual);
        }
    }
}