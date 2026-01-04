using Tyuiu.ZelenovaIV.Sprint5.Task1.V12.Lib;

namespace Tyuiu.ZelenovaIV.Sprint5.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fi = new FileInfo(path);
            bool fE = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fE);
        }
    }
}
