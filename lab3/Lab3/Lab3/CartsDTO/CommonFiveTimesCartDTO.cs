using System;
namespace Lab3.Carts
{
    public class CommonFiveTimesCartDTO : BaseCartDTO
    {
        public CommonFiveTimesCartDTO()
        {
            day = 0;
            times = 5;
            price = 1;
            isDiscount = false;
            isCommon = true;
            discount = 0;
            isCumulative = false;
            accountCumulate = 0;
        }
    }
}
