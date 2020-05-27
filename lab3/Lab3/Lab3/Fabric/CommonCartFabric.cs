using System;
using Lab3.Model;
using Lab3.Carts;

namespace Lab3.Fabric
{
    public class CommonCartFabric: ICartFabric
    {
        public dynamic create(ICartDTO dto)
        {
            IBaseCartModel model;

            if (dto.day > 0)
            {
                model = new CommonDayCartModel
                {
                    amountDays = dto.day,
                    type = Terminal.CART_TYPE_BY_DAY
                };
            }
            else if (dto.times > 0)
            {
                model = new CommonTimeCartModel
                {
                    times = dto.times,
                    type = Terminal.CART_TYPE_BY_TIME
                };
            }
            else
            {
                throw new ArgumentException();
            }

            model.price = dto.price;
            if (dto.isDiscount == true)
            {
                double discount = (double) dto.price * (dto.discount / (double) 100);
                int price = dto.price - Convert.ToInt32(discount);
                model.price = price;
            }

            model.ID =  Guid.NewGuid();
            
            model.blocked = false;
            return model;
        }
    }
}
