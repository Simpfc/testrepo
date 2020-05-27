using System;
using System.Collections.Generic;
using Lab4.Persons;

namespace Lab4
{
    public interface IRoad
    {
        Dictionary<string, IVehicle> road { get; set; }
        void AddVehicle(IVehicle vehicle);
        void RemoveVehicle(IVehicle vehicle);
        IVehicle GetVehicleByID(Guid id);
        bool HasVehicle(IVehicle vehicle);
        int GetVehiclesAmount();
        int GetCountOfPersons();
    }
}
