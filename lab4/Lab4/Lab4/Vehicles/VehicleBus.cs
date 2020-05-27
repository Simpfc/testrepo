using System;
using System.Collections.Generic;

namespace Lab4
{
    public class VehicleBus: Vehicle
    {
        public VehicleBus()
        {
            this.limit = Constants.VEHICLE_BUS_LIMIT;
            this.allovedTypesOfPassengers = new List<int>();
            this.allovedTypesOfPassengers.Add(Constants.PERSON_TYPE_ALL);
        } 
    }
}
