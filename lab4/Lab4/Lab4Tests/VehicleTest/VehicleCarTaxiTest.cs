using Lab4.Persons;
using NUnit.Framework;

namespace Lab4.Tests
{
    public class VehicleCarTaxiTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPassengersLimit()
        {
            IVehicle bus = new VehicleCarTaxi();

            Assert.AreEqual(Constants.VEHICLE_TAXI_LIMIT, bus.GetLimit());
        }

        [Test]
        public void TestListOfAllowedPassenfers()
        {
            IVehicle bus = new VehicleCarTaxi();

            Assert.IsTrue(bus.GetAllovedTypesOfPassengers().Count > 0);
        }

        [Test]
        public void TestAccessOfPassengers()
        {
            IVehicle vehicle = new VehicleCarTaxi();
            IPerson civilian = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson police = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson firefighter = new Person(Constants.PERSON_TYPE_FIREFIGHTER);

            Assert.IsTrue(vehicle.CheckPersonAccess(civilian));
            Assert.IsTrue(vehicle.CheckPersonAccess(police));
            Assert.IsTrue(vehicle.CheckPersonAccess(firefighter));
        }
    }
}