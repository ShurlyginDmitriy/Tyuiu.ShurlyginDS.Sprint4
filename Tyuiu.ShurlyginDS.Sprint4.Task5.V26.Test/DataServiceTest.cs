using Tyuiu.ShurlyginDS.Sprint4.Task5.V26.Lib;

namespace Tyuiu.ShurlyginDS.Sprint4.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -4, -2, 0, 2, 4 },
                                          { -3, -1, 1, 3, -4 },
                                          { 0, 4, -2, 1, 2 },
                                          { -1, 0, 3, -3, 4 },
                                          { 2, -4, -1, 0, 3 } };

            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { -4, -2, 0, 1, 1 },
                                          { -3, -1, 1, 1, -4 },
                                          { 0, 1, -2, 1, 1 },
                                          { -1, 0, 1, -3, 1 },
                                          { 1, -4, -1, 0, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
