using System;
namespace Lab3.Carts
{
    public class CommonTwentyTimesCartDTO : BaseCartDTO
    {
        public CommonTwentyTimesCartDTO()
        {
            day = 0;
            times = 20;
            price = 17;
            isDiscount = false;
            isCommon = true;
            discount = 0;
            isCumulative = false;
            accountCumulate = 0;
        }
    }
}
