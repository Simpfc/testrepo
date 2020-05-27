using NUnit.Framework;
using Lab3.Model;
using Lab3.Carts;
using System.Collections.Generic;

namespace Lab3.Tests
{
    public class TestCardPerTimeCommon
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestCardHasCorrectTypePerTime()
        {
            Terminal terminal = new Terminal();

            ICartDTO dto = new CommonFiveTimesCartDTO();
            IBaseCartModel card = terminal.Create(dto);
            Assert.IsTrue(card.GetCartType() == Terminal.CART_TYPE_BY_TIME);
        }

        [Test]
        public void TestBlockCartPerTime()
        {
            ICartDTO dto = new CommonFiveTimesCartDTO();
            Terminal terminal = new Terminal();
            IBaseCartModel cart = terminal.Create(dto);

            Assert.IsTrue(terminal.CheckAccess(cart));

            terminal.BlockCart(cart);
            Assert.IsFalse(terminal.CheckAccess(cart));

            terminal.UnBlockCart(cart);
            Assert.IsTrue(terminal.CheckAccess(cart));
        }

        [Test]
        public void TestWitdrawCartPerTime()
        {
            ICartDTO dto = new CommonFiveTimesCartDTO();
            Terminal terminal = new Terminal();
            IBaseCartModel cart = terminal.Create(dto);

            Assert.IsTrue(terminal.CheckAccess(cart));

            terminal.Withdraw(cart);
            Assert.IsTrue(terminal.CheckAccess(cart));

            terminal.Withdraw(cart);
            Assert.IsTrue(terminal.CheckAccess(cart));

            terminal.Withdraw(cart);
            Assert.IsTrue(terminal.CheckAccess(cart));

            terminal.Withdraw(cart);
            Assert.IsTrue(terminal.CheckAccess(cart));

            terminal.Withdraw(cart);
            Assert.AreEqual(5, cart.GetPassedAmount());
            Assert.IsFalse(terminal.CheckAccess(cart));

            terminal.Withdraw(cart);
            Assert.AreEqual(cart.GetDeclinedAmount(), 1);
        }

    }
}