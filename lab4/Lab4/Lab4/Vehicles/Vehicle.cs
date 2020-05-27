using System;
using System.Collections.Generic;
using Lab4.Persons;
using Lab4.Exception;

namespace Lab4
{
    public class Vehicle: IVehicle
    {
        public Guid ID { get; set; }
        public Dictionary<string, IPerson> persons { get; set; }
        public int limit { get; set; }
        public List<int> allovedTypesOfPassengers { get; set; }

        public Vehicle()
        {
            this.persons = new Dictionary<string, IPerson>();
            this.ID = Guid.NewGuid();
        }

        public bool HasFreePlace()
        {
            if (this.persons.Count >= this.limit)
            {
                return false;
            }

            return true;
        }

        public int GetAmountPassengers()
        {
            return this.persons.Count;
        }

        public bool CheckPersonAccess(IPerson person)
        {
            bool hasTypeAll = allovedTypesOfPassengers.Contains(Constants.PERSON_TYPE_ALL);
            bool hasSpecificType = allovedTypesOfPassengers.Contains(person.GetPersonType());
            if (hasSpecificType == false && hasTypeAll == false)
            {
                return false;
            }

            return true;
        }

        public bool AddPassenger(IPerson person)
        {
            if (this.HasFreePlace() == false)
            {
                throw new VehicleIsFullException("Sorry, we do not have empty places. Try to catch a next one!");
            }

            if (this.CheckPersonAccess(person) == false) {
                throw new PassengerTypeIsNotAllowedException("Sorry, you do not have access to here!");
            }

            if (this.HasPerson(person) == true)
            {
                throw new PassengerIsAlreadyIExistsException("You are already in the car!");
            }

            this.persons.Add(person.ID.ToString(), person);

            return true;
        }

        public void RemovePassenger(IPerson person)
        {
            IPerson model = this.GetPersonById(person.ID);
            if (model is IPerson)
            {
               this.persons.Remove(person.ID.ToString());
               return;
            }

            throw new PassengerNotExistsException("Passenger is not in the car!");
        }

        public bool HasPerson(IPerson person)
        {
            IPerson model = this.GetPersonById(person.ID);
            if (model is IPerson)
            {
                return true;
            }

            return false;
        }

        public IPerson GetPersonById(Guid id)
        {
            IPerson model;
            this.persons.TryGetValue(id.ToString(), out model);
            return model;
        }

        public int GetLimit()
        {
            return this.limit;
        }

        public List<int> GetAllovedTypesOfPassengers()
        {
            return this.allovedTypesOfPassengers;
        }

        public bool HasPerson(Guid id)
        {
            throw new NotImplementedException();
        }

        public int GetAmountOfFreePlaces()
        {
            return this.limit - this.persons.Count;
        }
    }
}
