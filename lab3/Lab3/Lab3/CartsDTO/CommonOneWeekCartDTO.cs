using System;
namespace Lab3.Carts
{
    public class CommonOneWeekCartDTO : BaseCartDTO
    {
        public CommonOneWeekCartDTO()
        {
            day = 7;
            times = 0;
            price = 15;
            isDiscount = false;
            isCommon = true;
            discount = 0;
            isCumulative = false;
            accountCumulate = 0;
        }
    }
}
