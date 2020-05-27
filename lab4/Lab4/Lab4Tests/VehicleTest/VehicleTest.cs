using Lab4.Persons;
using NUnit.Framework;

namespace Lab4.Tests
{
    public class VehicleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAmountOfFreePlaces()
        {
            IVehicle bus = new VehicleBus();
            IPerson civilian = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson police = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson firefighter = new Person(Constants.PERSON_TYPE_FIREFIGHTER);
            IPerson civilian2 = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson civilian3 = new Person(Constants.PERSON_TYPE_COMMON);

            bus.AddPassenger(civilian);
            bus.AddPassenger(civilian2);
            bus.AddPassenger(civilian3);
            bus.AddPassenger(police);
            bus.AddPassenger(firefighter);

            Assert.IsTrue(bus.HasFreePlace());
            Assert.AreEqual(5, bus.GetAmountPassengers());
            Assert.AreEqual(Constants.VEHICLE_BUS_LIMIT - 5, bus.GetAmountOfFreePlaces());
        }
    }
}