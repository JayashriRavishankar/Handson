using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using MagicFilesLib;


namespace DirectoryExplorer.Tests
{
    public class DirectoryExlporerTests
    {
        private readonly string _file1 = "file.txt";

        private readonly string _file2 = "file2.txt";

        Mock<IDirectoryExplorer> mock;

        [OneTimeSetUp]
        public void init()
        {
            mock = new Mock<IDirectoryExplorer>();
        }

        [Test]
        [TestCase("filepath")]

        public void TestMethod(string path)
        {
            ICollection<string> hardcode = new List<string>() { _file1, _file2 };
            mock.Setup(p => p.GetFiles(path)).Returns(hardcode);

            Assert.IsNotNull(mock.Object.GetFiles(path));
            Assert.AreEqual(2, mock.Object.GetFiles(path).Count);

            Assert.Contains(_file1, (System.Collections.ICollection)mock.Object.GetFiles(path));

        }
    }
}
