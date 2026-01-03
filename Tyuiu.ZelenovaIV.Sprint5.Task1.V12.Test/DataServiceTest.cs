using Tyuiu.ZelenovaIV.Sprint5.Task1.V12.Lib;

namespace Tyuiu.ZelenovaIV.Sprint5.Task1.V12.Test
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
