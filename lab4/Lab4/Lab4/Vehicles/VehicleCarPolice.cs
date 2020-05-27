using System;
using System.Collections.Generic;

namespace Lab4
{
    public class VehicleCarPolice: Vehicle
    {
        public VehicleCarPolice()
        {
            this.limit = Constants.VEHICLE_POLICE_LIMIT;
            this.allovedTypesOfPassengers = new List<int>();
            this.allovedTypesOfPassengers.Add(Constants.PERSON_TYPE_POLICE);
        }
    }
}
