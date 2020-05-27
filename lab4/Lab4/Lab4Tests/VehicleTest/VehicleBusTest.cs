using Lab4.Persons;
using NUnit.Framework;

namespace Lab4.Tests
{
    public class VehicleBusTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPassengersLimit()
        {
            IVehicle bus = new VehicleBus();

            Assert.AreEqual(Constants.VEHICLE_BUS_LIMIT, bus.GetLimit());
        }

        [Test]
        public void TestListOfAllowedPassenfers()
        {
            IVehicle bus = new VehicleBus();

            Assert.IsTrue(bus.GetAllovedTypesOfPassengers().Count > 0);
        }

        [Test]
        public void TestAccessOfPassengers()
        {
            IVehicle bus = new VehicleBus();
            IPerson civilian = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson police = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson firefighter = new Person(Constants.PERSON_TYPE_FIREFIGHTER);

            Assert.IsTrue(bus.CheckPersonAccess(civilian));
            Assert.IsTrue(bus.CheckPersonAccess(police));
            Assert.IsTrue(bus.CheckPersonAccess(firefighter));
        }
    }
}