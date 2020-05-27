using NUnit.Framework;
using Lab3.Model;
using Lab3.Carts;
using System.Collections.Generic;
using System;

namespace Lab3.Tests
{
    public class TetsTerminal
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateCartCommon()
        {
            ICartDTO dtoCartFiveTimes = new CommonFiveTimesCartDTO();
            Terminal terminal = new Terminal();
            IBaseCartModel cart = terminal.Create(dtoCartFiveTimes);
            Assert.IsTrue(cart is IBaseCartModel);
        }

        [Test]
        public void TestCreateCartDiscount()
        {
            ICartDTO dtoWithDiscount = new DiscountFiftyPercTwentyTimesCartDTO();
            ICartDTO dtoWithoutDiscount = new CommonTwentyTimesCartDTO();
            Terminal terminal = new Terminal();
            IBaseCartModel cartWithDiscount = terminal.Create(dtoWithDiscount);
            IBaseCartModel cartWithoutDiscount = terminal.Create(dtoWithoutDiscount);

            int price1 = cartWithDiscount.GetPrice();
            int price2 = cartWithoutDiscount.GetPrice();
            Assert.IsTrue(price1 < price2);
        }

        [Test]
        public void TestBlockUnblockCard()
        {
            ICartDTO dtoCardFiveTimes = new CommonFiveTimesCartDTO();
            Terminal terminal = new Terminal();
            IBaseCartModel card = terminal.Create(dtoCardFiveTimes);

            Assert.IsTrue(card.HasAccess());

            card.Block();
            Assert.IsFalse(card.HasAccess());

            card.UnBlock();
            Assert.IsTrue(card.HasAccess());

        }

        [Test]
        public void TestPassById()
        {
            ICartDTO dtoCartFiveTimes = new CommonFiveTimesCartDTO();

            Terminal terminal = new Terminal();
            IBaseCartModel card = terminal.Create(dtoCartFiveTimes);

            // valid card
            Assert.IsTrue(terminal.PassById(card.ID));

            // fake card
            Assert.IsFalse(terminal.PassById(Guid.NewGuid()));

            // if card is blocked
            card.Block();
            Assert.IsFalse(terminal.PassById(card.ID));

            // the card is run out of limit
            card.UnBlock();
            Assert.IsTrue(terminal.PassById(card.ID));
            terminal.PassById(card.ID);
            terminal.PassById(card.ID);
            terminal.PassById(card.ID);
            Assert.IsFalse(terminal.PassById(card.ID));
        }

        [Test]
        public void TestWithdraw()
        {
            ICartDTO dtoCartFiveTimes = new CommonFiveTimesCartDTO();
            Terminal terminal = new Terminal();
            IBaseCartModel card = terminal.Create(dtoCartFiveTimes);

            Assert.IsTrue(card.HasAccess());

            terminal.Withdraw(card);
            terminal.Withdraw(card);
            terminal.Withdraw(card);
            terminal.Withdraw(card);
            terminal.Withdraw(card);

            Assert.IsFalse(card.HasAccess());

        }
    }
}