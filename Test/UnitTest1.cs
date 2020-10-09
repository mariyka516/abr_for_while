using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFor8()
        {
            int a = 1;
            int b = 4;
            int rez = 24;
            int rez8 = masha.integer.For8(a,b);
            Assert.AreEqual(rez, rez8);
        }
        [Test]
        public void TestFor12()
        {
            int N=3;
            double rez = 2.4024;
            double rez12 = masha.integer.For12(N);
            Assert.AreEqual(rez, rez12);
        }
        [Test]
        public void TestWhile1()
        {
            int A = 5;
            int B = 2;
            int rez = 1;
            int rez12 = masha.integer.While1(A, B);
            Assert.AreEqual(rez, rez12);
        }
        [Test]
        public void TestWhile4()
        {
            int N = 6;
            int rez = 0;
            int rez4 = masha.integer.while4(N);
            Assert.AreEqual(rez, rez4);
        }
    }
}
