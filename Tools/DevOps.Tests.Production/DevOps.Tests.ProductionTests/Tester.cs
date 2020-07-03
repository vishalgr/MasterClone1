using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Tests.Production;

namespace DevOps.Tests.ProductionTests
{
    [TestFixture]
    public class Tester
    {
        Helper hel = new Helper();
        randomnumbergenerator ran = new randomnumbergenerator();

        [Test]
        public void case1()
        {

            int r = hel.add(20, 30);
            Assert.AreEqual(50, r);
        }
        [Test]
        public void case2()
        {

            int r = hel.add(10, 40);
            Assert.AreEqual(50, r);
        }
        [Test]
        public void case3()
        {

            int r = hel.add(50, 30);
            Assert.AreEqual(70, r);
        }
        [Test]
        public void case4()
        {

            int r = hel.add(50, 30);
            Assert.AreEqual(60, r);
        }
        [Test]
        public void case5()
        {

            int r = hel.add(50, 30);
            Assert.AreEqual(70, r);
        }
        [Test]
        public void case6()
        {

            int r = hel.add(50, 30);
            Assert.AreEqual(80, r);
        }
        [Test]
        public void case7()
        {

            int r = hel.add(50, 30);
            Assert.AreEqual(80, r);
        }
        [Test]
        public void case8()
        {
            int r = hel.add(50, 30);
            Assert.AreEqual(80, r);
        }
        [Test]
        public void case9()
        {

            int r = hel.add(50, 30);
            Assert.AreEqual(80, r);
        }
        [Test]
        public void case10()
        {

            int r = hel.add(50, 30);
            Assert.AreEqual(80, r);
        }

        [Test]
        public void case11()
        {
            int ra = ran.RandomNumber();

            int z = ra % 2;
            Assert.AreEqual(0, z, "The number is not even");
            Console.WriteLine("the number is even");

        }
        [Test]
        public void case12()
        {
            int ra = ran.RandomNumber();

            int z = ra % 2;
            Assert.AreEqual(1, z, "the number is not odd");
            Console.WriteLine("The number is odd");
        }

        [Test]
        public void case13()
        {
            int ra = ran.RandomNumber();

            Assert.That(ra, Is.GreaterThan(15));
            Console.WriteLine("the number is greater");
            Console.WriteLine(ra);
        }
        [Test]
        public void case14()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.EqualTo(15));
            Console.WriteLine("pass");
        }
        [Test]
        public void case15()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.LessThanOrEqualTo(20));
        }

        [Test]
        public void case16()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.Not.EqualTo(30));
        }
        [Test]
        public void case17()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.LessThan(40));
        }

        [Test]
        public void case18()
        {
            int r = hel.add(50, 30);
            Assert.AreEqual(80, r);
        }
        [Test]
        public void case19()
        {
            int r = hel.add(90, 10);
            Assert.AreEqual(100, r);
        }
        [Test]
        public void case20()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.Not.Null);

        }
        [Test]
        public void case21()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.Negative);
        }
        [Test]
        public void case22()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.Positive);
            Console.WriteLine(ra);
        }
        [Test]
        public void case23()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.LessThanOrEqualTo(35));
        }
        [Test]
        public void case24()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.GreaterThanOrEqualTo(45));
        }
        [Test]
        public void case25()
        {
            int ra = ran.RandomNumber();
            Assert.That(ra, Is.LessThanOrEqualTo(25));
        }
    }
}

