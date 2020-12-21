using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToArabicNS;

namespace RomanToArabicTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string roman = "I";
            int expected = 1;

            int actuall = RtoA.romanToArabic(roman);
            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string roman = "IX";
            int expected = 9;

            int actuall = RtoA.romanToArabic(roman);
            Assert.AreEqual(expected, actuall);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string roman = "XI";
            int expected = 11;

            int actuall = RtoA.romanToArabic(roman);
            Assert.AreEqual(expected, actuall);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string roman = "MCMXCIX";
            int expected = 1999;

            int actuall = RtoA.romanToArabic(roman);
            Assert.AreEqual(expected, actuall);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string roman = "MMXV";
            int expected = 2015;

            int actuall = RtoA.romanToArabic(roman);
            Assert.AreEqual(expected, actuall);
        }
    }
}
