using System;

namespace Lab4.Persons
{
    public class Person : IPerson
    {
        public Guid ID { get; set; }
        public int type { get; set; }

        public Person (int type)
        {
            this.type = type;
            this.ID = Guid.NewGuid();
        }

        public int GetPersonType()
        {
            return this.type;
        }
    }
}
