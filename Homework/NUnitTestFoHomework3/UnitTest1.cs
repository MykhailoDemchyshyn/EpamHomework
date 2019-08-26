using NUnit.Framework;
using Homework3;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {


        }
        List<string> list = new List<string> { "qwer", "tyui", "asdf", "ghjk", "zxcv" };
        Program program = new Program();
        [Test]
        public void Test1()
        {
            var result = program.DisplayPage(1, list);
            Assert.AreEqual(list[0], result);
        }

        [Test]
        public void Test2()
        {
            var result = program.DisplayPage(2, list);
            Assert.AreEqual(list[1], result);
        }

        [Test]
        public void Test3()
        {
            var result = program.DisplayPage(3, list);
            Assert.AreEqual(list[2], result);
        }

        [Test]
        public void Test4()
        {
            var result = program.DisplayPage(4, list);
            Assert.AreEqual(list[3], result);
        }

        [Test]
        public void Test5()
        {
            var result = program.DisplayPage(5, list);
            Assert.AreEqual(list[4], result);
        }
    }
}