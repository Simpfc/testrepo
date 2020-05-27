using System;
namespace Lab3.Carts
{
    public class BaseCartDTO: ICartDTO
    {
        public int day { get; set; }
        public int times { get; set; }
        public int price { get; set; }
        public bool isDiscount { get; set; }
        public bool isCommon { get; set; }
        public int discount { get; set; }
        public bool isCumulative { get; set; }
        public int accountCumulate { get; set; }
    }
}
