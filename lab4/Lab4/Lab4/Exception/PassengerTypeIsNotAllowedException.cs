using System;
namespace Lab4.Exception
{
    [Serializable]
    public class PassengerTypeIsNotAllowedException : SystemException
    {
        public PassengerTypeIsNotAllowedException(string message): base(message)
        {
        }

    }
}
