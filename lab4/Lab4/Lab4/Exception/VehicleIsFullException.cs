using System;
namespace Lab4.Exception
{
    [Serializable]
    public class VehicleIsFullException: SystemException
    {
        public VehicleIsFullException(string message): base(message)
        {
        }

    }
}
