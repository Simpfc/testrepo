using System;

namespace Lab4.Persons
{
    public interface IPerson
    {
        Guid ID { get; set; }
        int type { get; set; }
        int GetPersonType();

    }
}
