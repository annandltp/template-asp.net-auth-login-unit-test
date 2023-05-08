using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace TestProject1.TestMethod
{
    internal class MathTestBL
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSum()
        {
            var mathBL = new MathBL();
            int result = mathBL.sum(2, 3);
            Assert.IsTrue(result == 9);
            Assert.Pass();
        }
    }
}
