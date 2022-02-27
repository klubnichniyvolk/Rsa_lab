using System;
using NUnit.Framework;
using Rsa_lab;

namespace RsaTest
{
    public class RsaTests
    {
        [Test]
        public void SimpleDecodeAndDecode()
        {
            RSA rsaEncryptor = new RSA(5, 71);
            string result = rsaEncryptor.Decode(rsaEncryptor.Encode("привет мир"));
            Assert.AreEqual("ПРИВЕТ МИР", result);
        }
        [Test]
        public void EmptyDecodeAndDecode()
        {
            RSA rsaEncryptor = new RSA(5, 71);
            string result = rsaEncryptor.Decode(rsaEncryptor.Encode(""));
            Assert.AreEqual("", result);
        }
        [Test]
        public void SpacesDecodeAndDecode()
        {
            RSA rsaEncryptor = new RSA(7, 113);
            string result = rsaEncryptor.Decode(rsaEncryptor.Encode("     "));
            Assert.AreEqual("     ", result);
        }
        [Test]
        public void DigitsDecodeAndDecode()
        {
            RSA rsaEncryptor = new RSA(11, 29);
            string result = rsaEncryptor.Decode(rsaEncryptor.Encode("1234567890"));
            Assert.AreEqual("1234567890", result);
        }
        [Test]
        public void ComplexDecodeAndDecode()
        {
            RSA rsaEncryptor = new RSA(53, 101);
            string result = rsaEncryptor.Decode(rsaEncryptor.Encode("Привет, Мир! 123"));
            Assert.AreEqual("ПРИВЕТ, МИР! 123", result);
        }
    }
}