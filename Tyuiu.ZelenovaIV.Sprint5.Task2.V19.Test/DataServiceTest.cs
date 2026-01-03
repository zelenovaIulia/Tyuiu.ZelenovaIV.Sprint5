using Tyuiu.ZelenovaIV.Sprint5.Task2.V19.Lib;

namespace Tyuiu.ZelenovaIV.Sprint5.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
