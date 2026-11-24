using Tyuiu.ShurlyginDS.Sprint4.Task7.V6.Lib;

namespace Tyuiu.ShurlyginDS.Sprint4.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "458963214789";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}
