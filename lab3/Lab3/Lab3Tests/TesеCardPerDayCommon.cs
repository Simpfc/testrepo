using NUnit.Framework;
using Lab3.Model;
using Lab3.Carts;
using System.Collections.Generic;
using Lab3.Fabric;
using System;

namespace Lab3.Tests
{
    public class TestCardPerDayCommon
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCardHasCorrectType()
        {
            ICartDTO dto = new CommonOneDayCartDTO();
            CommonCartFabric fabric = new CommonCartFabric();
            IBaseCartModel card = fabric.create(dto);

            Assert.IsTrue(card.GetCartType() == Terminal.CART_TYPE_BY_DAY);
        }

        [Test]
        public void TestWithdraw()
        {
            ICartDTO dto = new CommonOneDayCartDTO();
            CommonCartFabric fabric = new CommonCartFabric();
            CommonDayCartModel card = (CommonDayCartModel)fabric.create(dto);

            Assert.IsTrue(card.HasAccess());

            // two days later
            DateTime curDay = DateTime.Now;
            card.startDayTime = curDay.AddDays(-2);

            Assert.IsFalse(card.HasAccess());
        }
    }
}