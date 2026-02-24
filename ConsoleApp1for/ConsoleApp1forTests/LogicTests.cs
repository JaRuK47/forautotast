using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1for.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void NoRepit()
        {
            string text = Logic.Result(2, [1,2]);
            Assert.AreEqual("0 0", text);
        }

        [TestMethod()]
        public void Repit()
        {
            string text = Logic.Result(3, [1, 2, 2]);
            Assert.AreEqual("2 3", text);
        }

        [TestMethod()]
        public void RepitFirst()
        {
            string text = Logic.Result(3, [1, 1, 2]);
            Assert.AreEqual("1 2", text);
        }
    }
}