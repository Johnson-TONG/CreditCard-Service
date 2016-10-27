using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraLazy.Domain.BusinessRules;


namespace CreditCardServiceTest
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestCardNumber1()
        {
            // TODO: Add your test code here
            string CardNumber = "5105105105105100";
            
            IsCardNumberValid IsCardValid = new IsCardNumberValid(CardNumber);
            Assert.IsTrue(IsCardValid.Validate());
        }
        [Test]
        public void TestCardNumber2()
        {
            // TODO: Add your test code here
            string CardNumber = "4111111111111111";

            IsCardNumberValid IsCardValid = new IsCardNumberValid(CardNumber);
            Assert.IsTrue(IsCardValid.Validate());
        }
        [Test]
        public void TestCardNumber3()
        {
            // TODO: Add your test code here
            string CardNumber = "411111111111111a";

            IsCardNumberValid IsCardValid = new IsCardNumberValid(CardNumber);
            Assert.IsTrue(!IsCardValid.Validate());
        }
        [Test]
        public void TestCardNumber4()
        {
            // TODO: Add your test code here
            string CardNumber = "abcdefghijklmnop";

            IsCardNumberValid IsCardValid = new IsCardNumberValid(CardNumber);
            Assert.IsTrue(!IsCardValid.Validate());
        }
    }
}
