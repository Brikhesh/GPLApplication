using GPLApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPLUnitTesting
{
    [TestClass]
    public class CircleTest
    {
           [TestMethod]
            public void TestCircle()
            {
                var r = new Circle();
                int x = 100, y = 50, radius = 40;
                r.Set(x, y, radius);
                Assert.AreEqual(100, r.x); //Assert.AreEqual(expected,actual)
            }
    }
}
