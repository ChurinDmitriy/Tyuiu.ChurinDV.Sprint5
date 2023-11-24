using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint5.Task5.V2.Lib;
using System.IO;

namespace Tyuiu.ChurinDV.Sprint5.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint5\Tyuiu.ChurinDV.Sprint5.Task5.V2\bin\Debug\InPutDataFileTask5V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
