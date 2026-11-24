using Tyuiu.ShurlyginDS.Sprint4.Task2.Lib;

namespace Tyuiu.ShurlyginDS.Sprint4.Task2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 3, 4, 5, 6, 7, 8, 9, 4, 6 };

            int res = ds.Calculate(numsArray);
            int wait = 945;

            Assert.AreEqual(wait, res);
        }
    }
}
