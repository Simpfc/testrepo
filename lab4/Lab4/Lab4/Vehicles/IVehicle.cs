using System;
using System.Collections.Generic;
using Lab4.Persons;

namespace Lab4
{
    public interface IVehicle
    {
        Guid ID { get; set; }
        int limit { get; set; }
        List<int> allovedTypesOfPassengers { get; set; }
        Dictionary<string, IPerson> persons { get; set; }
        int GetAmountPassengers();
        bool AddPassenger(IPerson person);
        void RemovePassenger(IPerson person);
        bool CheckPersonAccess(IPerson person);
        IPerson GetPersonById(Guid id);
        bool HasPerson(Guid id);
        int GetLimit();
        List<int> GetAllovedTypesOfPassengers();
        bool HasFreePlace();
        int GetAmountOfFreePlaces();
    }
}
