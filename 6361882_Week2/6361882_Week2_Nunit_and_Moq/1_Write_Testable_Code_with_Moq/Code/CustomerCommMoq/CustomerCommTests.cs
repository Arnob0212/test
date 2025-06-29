using Castle.Core.Smtp;
using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerCommMoq
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> mockMailSender;
        private CustomerComm customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            customerComm = new CustomerComm(mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ReturnsTrue()
        {
            var result = customerComm.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
