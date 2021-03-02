using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PlayersManagerLib;


namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerManagerTests
    {
        Mock<IPlayerMapper> _mock;

        [OneTimeSetUp]
        public void Init()
        {
            _mock = new Mock<IPlayerMapper>(MockBehavior.Loose);
        }

        [Test]

        [TestCase("Jayasssri")]
        //[TestCase("India")]

        public void RegisterNewPlayer_whencalled_RegisterANewPlayer(string name)
        {
            _mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);
            Player result = Player.RegisterNewPlayer(name, _mock.Object);
            NUnit.Framework.Assert.AreEqual(result.Name, name);

        }
        [Test]
        //[TestCase(null)]
        //[TestCase("")]
        //[TestCase("")]
        [TestCase("Jayasri")]
        [ExpectedException(typeof(ArgumentException))]
        public void RegisterNewPlayer_whencalled_ReturnsArgumentException(string name)
        {
            Player result = Player.RegisterNewPlayer(name, _mock.Object);
        }

    }

}