using System;
using System.Collections.Generic;

namespace Lab4
{
    public class VehicleCarFireFighter: Vehicle
    {
        public VehicleCarFireFighter()
        {
            this.limit = Constants.VEHICLE_FIREFIGHTER_CAR_LIMIT;
            this.allovedTypesOfPassengers = new List<int>();
            this.allovedTypesOfPassengers.Add(Constants.PERSON_TYPE_FIREFIGHTER);
        }
    }
}
