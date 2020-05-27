using System;
namespace Lab3.Carts
{
    public class DiscountFiftyPercTwentyTimesCartDTO : BaseCartDTO
    {
        public DiscountFiftyPercTwentyTimesCartDTO()
        {
            day = 0;
            times = 20;
            price = 17;
            isDiscount = true;
            isCommon = true;
            discount = 50;
            isCumulative = false;
            accountCumulate = 0;
        }
    }
}
