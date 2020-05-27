using System;
using Lab3.Model;
using Lab3.Carts;

namespace Lab3.Fabric
{
    public interface ICartFabric
    {
        dynamic create(ICartDTO dto);
    }
}
