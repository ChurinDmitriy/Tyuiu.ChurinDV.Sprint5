using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ChurinDV.Sprint5.Task6.V14.Lib;


namespace Tyuiu.ChurinDV.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint5\Tyuiu.ChurinDV.Sprint5.Task6.V14\bin\Debug\InPutDataFileTask6V14.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint5\Tyuiu.ChurinDV.Sprint5.Task6.V14\bin\Debug\InPutDataFileTask6V14.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);

        }
    }
}
