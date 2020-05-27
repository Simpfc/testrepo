using System;
using System.Collections.Generic;

namespace Lab4.Dto
{
    public class BusVehicleDto : IVehicleDto
    {
        public int vehicleType = Constants.VEHICLE_TYPE_BUS;
        public int limit { get; set; }
        public List<int> allovedTypesOfPassengers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}