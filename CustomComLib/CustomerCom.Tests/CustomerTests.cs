using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomComLib;

namespace CustomerCom.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        Mock<IMailSender> mock;
        CustomerComm obj;
        
        [Test]
        [TestCase("cust123@abc.com", "Some Message", false)]
        [TestCase("jayasriravi98@gmail.com", "jayasri", true)]
        [TestCase("cust123@abc.com", "Some Message",true)]
        public void OneTimeSetUp(string toaddress, string name,bool expected)

        {
            mock = new Mock<IMailSender>();

            mock.Setup(p => p.SendMail(toaddress,name)).Returns(expected);
            obj = new CustomerComm(mock.Object);

            bool actual = obj.SendMailToCustomer(toaddress, name);
            Assert.AreEqual(expected,actual);
        }
    }
 
}
