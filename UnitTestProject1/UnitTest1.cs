using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Module_Test_Yehor_Medentsov;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new ZhvacniTV();
            var testres = 30;
            var res = calc.Plosha();
            Assert.AreEqual(testres, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var calc = new PlavajuchiTV();
            var testres = 42;
            var res = calc.Plosha();
            Assert.AreEqual(testres, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var calc = new Ekzoticni();
            var testres = 12;
            var res = calc.Plosha();
            Assert.AreEqual(testres, res);
        }

    }
}
