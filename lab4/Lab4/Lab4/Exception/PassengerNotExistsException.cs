using System;
namespace Lab4.Exception
{
    [Serializable]
    public class PassengerNotExistsException : SystemException
    {
        public PassengerNotExistsException(string message): base(message)
        {
        }

    }
}
