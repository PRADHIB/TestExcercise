﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestFileData
    {
        [DataTestMethod]
        [DataRow("-v", "c:/test.txt")]
        [DataRow("--v", "c:/test.txt")]
        [DataRow("/v", "c:/test.txt")]
        [DataRow("--version", "c:/test.txt")]
        [DataRow("-s", "c:/test.txt")]
        [DataRow("-s", "c:/test.txt")]
        [DataRow("--s", "c:/test.txt")]
        [DataRow("/s", "c:/test.txt")]
        [DataRow("--size", "c:/test.txt")]
        public void TestFileInfo(string fileOption, string filePath)
        {
            var actual = FileData.Program.ReturnFileInformation(fileOption, filePath);
            Assert.IsTrue(actual.Length > 0);

        }
    }
}

