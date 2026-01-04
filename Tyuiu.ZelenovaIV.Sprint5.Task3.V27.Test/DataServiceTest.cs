namespace Tyuiu.ZelenovaIV.Sprint5.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fi = new FileInfo(path);
            bool fE = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fE);
        }
    }
}
