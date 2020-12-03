using GPLApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPLUnitTesting
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestRect()
        {
            var r = new Rectangle();
            int x = 100, y = 50, height = 80, width = 75;
            r.Set(x, y, height, width);
            Assert.AreEqual(100, r.x); //Assert.AreEqual(expected,actual)
        }

    }
}
