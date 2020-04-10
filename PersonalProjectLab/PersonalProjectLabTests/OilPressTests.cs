using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;
namespace PersonalProjectLabTests
{
    [TestClass]
    public class OilPressTests
    {
        [TestMethod]
        public static void Main(string[] args) 
        {
            //arrange
            OilReading press = new OilReading(40,100);
            //act
            press.CheckOilSensor();
            //assert
            Assert.AreEqual("true", press);
        }
    }
}
