using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab2
{
    public class Person
    {
        string firstName;
        string secondName;
        int personAge;
        protected int x, y;

        public Person(string fName, string sName, int age)
        {
            firstName = fName;
            secondName = sName;
            personAge = age;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Person person = (Person)obj;

            if (person.firstName != firstName)
            {
                return false;
            }

            if (person.secondName != secondName)
            {
                return false;
            }

            if (person.personAge != personAge)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hash = Tuple.Create(firstName, secondName, personAge).GetHashCode();

            return hash;
                
        }

        public string ToJson()
        {
            string jsonString;

            jsonString = JsonSerializer.Serialize(new {
                fName = firstName,
                sName = secondName,
                age = personAge,
            });

            return jsonString;
        }
    }
}
