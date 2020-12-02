using GPLApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GPLUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 50;
            int y = 40;
            int height = 60;
            int width = 75;
            Rectangle rect = new Rectangle();
             rect.Set(50,40,60,75);

            rect.Set(x,y,height,width);

           // Assert.AreEqual();
        }
    }
}
