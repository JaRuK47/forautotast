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
        public void FirstNomber()
        {
            string text = Logic.ConvertToString(2);
            Assert.AreEqual("1 2", text);
        }

        [TestMethod()]
        public void FiveNomber()
        {
            string text = Logic.ConvertToString(5);
            Assert.AreEqual("4 5", text);
        }
    }
}