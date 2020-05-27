using System;
namespace Lab4.Exception
{
    [Serializable]
    public class PassengerIsAlreadyIExistsException : SystemException
    {
        public PassengerIsAlreadyIExistsException(string message): base(message)
        {
        }

    }
}
