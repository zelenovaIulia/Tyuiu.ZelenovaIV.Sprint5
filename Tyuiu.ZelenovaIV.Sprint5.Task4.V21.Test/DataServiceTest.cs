using Tyuiu.ZelenovaIV.Sprint5.Task4.V21.Lib;

namespace Tyuiu.ZelenovaIV.Sprint5.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V0.txt");
            File.WriteAllText(tempFile, "2.5");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(tempFile);

            double expected = Math.Round(Math.Pow(2.5, 3) * Math.Cos(2.5) + 2 * 2.5, 3);
            Assert.AreEqual(expected, result);
        }
    }
}