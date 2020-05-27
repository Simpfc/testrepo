using System;
namespace Lab3.Carts
{
    public interface ICartDTO
    {
        int day { get; set; }
        int times { get; set; }
        int price { get; set; }
        bool isDiscount { get; set; }
        bool isCommon { get; set; }
        int discount { get; set; }
        bool isCumulative { get; set; }
        int accountCumulate { get; set; }
    }
}
