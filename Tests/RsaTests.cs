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
            RSA rsaEncryptor = new RSA(3, 11);
            string result = rsaEncryptor.Decode(rsaEncryptor.Encode("hello world"));
            Assert.AreEqual("HELLO WORLD", result);
        }
    }
}