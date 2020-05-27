using System;
namespace Lab3.Carts
{
    public class CommonOneMonthCartDTO : BaseCartDTO
    {
        public CommonOneMonthCartDTO()
        {
            day = 30;
            times = 0;
            price = 40;
            isDiscount = false;
            isCommon = true;
            discount = 0;
            isCumulative = false;
            accountCumulate = 0;
        }
    }
}
