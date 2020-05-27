using System;
namespace Lab4.Exception
{
    [Serializable]
    public class RoadHasVehicleException : SystemException
    {
        public RoadHasVehicleException(string message): base(message)
        {
        }

    }
}
