using NUnit.Framework;
using Lab4.Persons;
using Lab4.Exception;

namespace Lab4.Tests
{
    public class RoadTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddVehicleToRoad()
        {
            IRoad road = new Road();
            IVehicle bus = new VehicleBus();

            int count = road.GetVehiclesAmount();
            Assert.AreEqual(0, count);

            road.AddVehicle(bus);

            Assert.IsTrue(road.GetVehiclesAmount() == 1);
        }

        [Test]
        public void TestRoadHasVehicle()
        {
            IRoad road = new Road();
            IVehicle bus = new VehicleBus();

            road.AddVehicle(bus);

            bool result = road.HasVehicle(bus);
            Assert.IsTrue(result);
        }


        [Test]
        public void TestCreateVehicleAndPassengers()
        {
            IRoad road = new Road();

            IVehicle bus = new VehicleBus();
            IVehicle taxi = new VehicleCarTaxi();
            IVehicle police = new VehicleCarPolice();
            IVehicle fireEngine = new VehicleCarFireFighter();

            IPerson p_common_1 = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson p_common_2 = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson p_common_3 = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson p_common_4 = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson p_common_5 = new Person(Constants.PERSON_TYPE_COMMON);
            IPerson p_common_6 = new Person(Constants.PERSON_TYPE_COMMON);

            IPerson p_police_1 = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson p_police_2 = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson p_police_3 = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson p_police_4 = new Person(Constants.PERSON_TYPE_POLICE);
            IPerson p_police_5 = new Person(Constants.PERSON_TYPE_POLICE);

            IPerson p_ff_1 = new Person(Constants.PERSON_TYPE_FIREFIGHTER);
            IPerson p_ff_2 = new Person(Constants.PERSON_TYPE_FIREFIGHTER);
            IPerson p_ff_3 = new Person(Constants.PERSON_TYPE_FIREFIGHTER);
            IPerson p_ff_4 = new Person(Constants.PERSON_TYPE_FIREFIGHTER);
            IPerson p_ff_5 = new Person(Constants.PERSON_TYPE_FIREFIGHTER);
            IPerson p_ff_6 = new Person(Constants.PERSON_TYPE_FIREFIGHTER);

            bus.AddPassenger(p_common_1);
            bus.AddPassenger(p_common_2);
            bus.AddPassenger(p_common_3);
            bus.AddPassenger(p_common_4);
            bus.AddPassenger(p_police_4);

            taxi.AddPassenger(p_common_5);
            taxi.AddPassenger(p_common_6);
            taxi.AddPassenger(p_ff_6);
            taxi.AddPassenger(p_police_5);

            police.AddPassenger(p_police_1);
            police.AddPassenger(p_police_2);
            police.AddPassenger(p_police_3);

            fireEngine.AddPassenger(p_ff_1);
            fireEngine.AddPassenger(p_ff_2);
            fireEngine.AddPassenger(p_ff_3);
            fireEngine.AddPassenger(p_ff_4);
            fireEngine.AddPassenger(p_ff_5);

            road.AddVehicle(bus);
            road.AddVehicle(taxi);
            road.AddVehicle(police);
            road.AddVehicle(fireEngine);

            Assert.IsTrue(road.HasVehicle(bus));
            Assert.IsTrue(road.HasVehicle(police));
            Assert.IsTrue(road.HasVehicle(fireEngine));

            var ex = Assert.Throws<RoadHasVehicleException>(() => road.AddVehicle(bus));
            Assert.IsTrue(ex is RoadHasVehicleException);

            int count = road.GetCountOfPersons();
            Assert.AreEqual(17, count);

            road.RemoveVehicle(fireEngine);
            Assert.IsFalse(road.HasVehicle(fireEngine));

        }
    }
}