using Lab4.Persons;
using NUnit.Framework;

namespace Lab4.Tests
{
    public class VehicleCarPoliceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPassengersLimit()
        {
            IVehicle bus = new VehicleCarPolice();

            Assert.AreEqual(Constants.VEHICLE_POLICE_LIMIT, bus.GetLimit());
        }

        [Test]
        public void TestListOfAllowedPassenfers()
        {
            IVehicle bus = new VehicleCarPolice();

            Assert.IsTrue(bus.GetAllovedTypesOfPassengers().Count > 0);
        }

        [Test]
        public void TestAccessOfPassengers()
        {
            IVehicle vehicle = new VehicleCarPolice();
            IPerson civilian = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson police = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson firefighter = new Person(Constants.PERSON_TYPE_FIREFIGHTER);

            Assert.IsFalse(vehicle.CheckPersonAccess(civilian));
            Assert.IsTrue(vehicle.CheckPersonAccess(police));
            Assert.IsFalse(vehicle.CheckPersonAccess(firefighter));
        }
    }
}