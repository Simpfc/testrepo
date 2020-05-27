using System;
namespace Lab3.Carts
{
    public class CommonTenTimesCartDTO : BaseCartDTO
    {
        public CommonTenTimesCartDTO()
        {
            day = 0;
            times = 10;
            price = 9;
            isDiscount = false;
            isCommon = true;
            discount = 0;
            isCumulative = false;
            accountCumulate = 0;
        }
    }
}
