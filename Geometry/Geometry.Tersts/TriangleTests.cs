using Geometry.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tersts
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestValidAndRightAngled()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Assert.IsTrue(t1.IsValid);
            Assert.IsTrue(t1.IsRightAngled);
        }

        [TestMethod]
        [DataRow(20, 2, 2, false)]
        [DataRow(2, 20, 2, false)]
        [DataRow(2, 2, 20, false)]
        [DataRow(2, 2, 2, true)]
        public void TestInvalid(int a, int b, int c, bool ev)
        {
            Triangle t = new Triangle(a, b, c);
            Assert.AreEqual(ev, t.IsValid);
        }

    }
}
