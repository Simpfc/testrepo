using NUnit.Framework;
using Lab3.Model;
using Lab3.Carts;
using Lab3.Fabric;
using System.Collections.Generic;

namespace Lab3.Tests
{
    public class TestCartPerTimeCommon
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCartHasAccessPerTime()
        {
            ICartDTO dto = new CommonFiveTimesCartDTO();
            CommonCartFabric fabric = new CommonCartFabric();
            IBaseCartModel card = fabric.create(dto);
            Assert.IsTrue(card.HasAccess());
        }
      

        [Test]
        public void TestBlockUnblockCard()
        {
            ICartDTO dto = new CommonFiveTimesCartDTO();
            CommonCartFabric fabric = new CommonCartFabric();
            IBaseCartModel card = fabric.create(dto);

            Assert.IsTrue(card.HasAccess());

            card.Block();
            Assert.IsFalse(card.HasAccess());

            card.UnBlock();
            Assert.IsTrue(card.HasAccess());
        }
    }
}