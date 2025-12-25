using Tyuiu.ZelenovaIV.Sprint5.Task0.V7.Lib;
using System.IO;

namespace Tyuiu.ZelenovaIV.Sprint5.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fi = new FileInfo(path);
            bool fE = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fE);

        }
    }
}
