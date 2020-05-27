using System;
using System.Collections.Generic;

namespace Lab4
{
    public class VehicleCarTaxi: Vehicle
    {

        public VehicleCarTaxi()
        {
            this.limit = Constants.VEHICLE_TAXI_LIMIT;
            this.allovedTypesOfPassengers = new List<int>();
            this.allovedTypesOfPassengers.Add(Constants.PERSON_TYPE_POLICE);
            this.allovedTypesOfPassengers.Add(Constants.PERSON_TYPE_FIREFIGHTER);
            this.allovedTypesOfPassengers.Add(Constants.PERSON_TYPE_COMMON);
        }
    }
}
