using GPLApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPLUnitTesting
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestTriangle()
        {
            var r = new Triangle();
            int x = 80, y = 50, height = 60, width = 75;
            r.Set(x, y, height, width);
            Assert.AreEqual(80, r.x); //Assert.AreEqual(expected,actual)
        }
    }
}
