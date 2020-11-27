using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheapFlow;
using System;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("start");
            new Program().TestIdea();
            Assert.AreEqual(1,1);
            
        }
    }
}
