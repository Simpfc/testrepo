using System;
namespace Lab3.Carts
{
    public class CommonOneDayCartDTO : BaseCartDTO
    {
        public CommonOneDayCartDTO()
        {
            day = 1;
            times = 0;
            price = 3;
            isDiscount = false;
            isCommon = true;
            discount = 0;
            isCumulative = false;
            accountCumulate = 0;
        }
    }
}
