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
        public void TestInvalid1()
        {
            Triangle t = new Triangle(20, 2, 2);
            Assert.IsFalse(t.IsValid);
        }

    }
}
