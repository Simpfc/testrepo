using Lab4.Persons;
using NUnit.Framework;

namespace Lab4.Tests
{
    public class VehicleFirefighterCarTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPassengersLimit()
        {
            IVehicle bus = new VehicleCarFireFighter();

            Assert.AreEqual(Constants.VEHICLE_FIREFIGHTER_CAR_LIMIT, bus.GetLimit());
        }

        [Test]
        public void TestListOfAllowedPassenfers()
        {
            IVehicle bus = new VehicleCarFireFighter();

            Assert.IsTrue(bus.GetAllovedTypesOfPassengers().Count > 0);
        }

        [Test]
        public void TestAccessOfPassengers()
        {
            IVehicle vehicle = new VehicleCarFireFighter();
            IPerson civilian = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson police = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson firefighter = new Person(Constants.PERSON_TYPE_FIREFIGHTER);

            Assert.IsFalse(vehicle.CheckPersonAccess(civilian));
            Assert.IsFalse(vehicle.CheckPersonAccess(police));
            Assert.IsTrue(vehicle.CheckPersonAccess(firefighter));
        }
    }
}