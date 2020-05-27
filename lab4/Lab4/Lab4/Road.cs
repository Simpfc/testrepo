using System;
using System.Collections.Generic;
using Lab4.Persons;
using Lab4.Exception;

namespace Lab4
{
    public class Road: IRoad
    {
        public Dictionary<string, IVehicle> road { get; set;}


        public Road()
        {
            this.road = new Dictionary<string, IVehicle>();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.HasVehicle(vehicle) == true)
            {
                throw new RoadHasVehicleException("The car alredy on the Road!");
            }

            this.road.Add(vehicle.ID.ToString(), vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            if (this.HasVehicle(vehicle) == true)
            {
                this.road.Remove(vehicle.ID.ToString());
            }

        }

        public IVehicle GetVehicleByID(Guid id)
        {
            IVehicle model;
            this.road.TryGetValue(id.ToString(), out model);
            return model;
        }

        public bool HasVehicle(IVehicle vehicle)
        {
            return this.GetVehicleByID(vehicle.ID) is IVehicle;
        }

        public int GetVehiclesAmount()
        {
            return this.road.Count;
        }

        public int GetCountOfPersons()
        {
            int count = 0;
            foreach (KeyValuePair<string, IVehicle> entry in this.road)
            {
                count += entry.Value.GetAmountPassengers();
            }

            return count;
        }
    }
}
