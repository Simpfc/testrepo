using System;
using Lab3.Fabric;
using Lab3.Model;
using Lab3.Carts;
using System.Collections.Generic;

namespace Lab3
{
    public class Terminal: ITerminal
    {
        static Dictionary<string, IBaseCartModel> state = new Dictionary<string, IBaseCartModel>();
        public const int CART_TYPE_BY_DAY = 1;
        public const int CART_TYPE_BY_TIME = 2;

        public const int CART_COMMON = 1;
        public const int CART_DISCOUNT = 2;

        public const int TERM_NO_LIMIT = 0;
        public const int TERM_ONE_DAY = 1;
        public const int TERM_WEEK = 7;
        public const int TERM_MONTH = 30;

        public const int LIMIT_NO_LIMIT = 0;
        public const int LIMIT_FIVE = 5;
        public const int LIMIT_TEN = 10;
        public const int LIMIT_TWENTY = 20;

        public IBaseCartModel GetCartByID(Guid id)
        {
            IBaseCartModel model;
            state.TryGetValue(id.ToString(), out model);
            return model;
        }

        public void UnBlockCart(IBaseCartModel model)
        {
            model.UnBlock();
        }

        public void BlockCart(IBaseCartModel model)
        {
            model.Block();
        }

        public void Withdraw(IBaseCartModel cart)
        {
            cart.Withdraw();
        }

        public bool CheckAccess(IBaseCartModel cart)
        {
            return cart.HasAccess();
        }

        public bool PassById(Guid id)
        {
            IBaseCartModel cart = this.GetCartByID(id);
            if (cart is null)
            {
                return false;
            }

            if (cart.HasAccess() == false)
            {
                return false;
            }

            cart.Withdraw();

            return true;
        }

        public IBaseCartModel Create(ICartDTO cartDto)
        {
            ICartFabric fabric;
            IBaseCartModel model;
            if (cartDto.isCommon)
            {
                fabric = new CommonCartFabric();
                model = fabric.create(cartDto);
            }
            //else if (cartDto.isDiscount)
            //{
            //    fabric = new DiscountCartFabric();
            //    model = fabric.create(cartDto);
            //}
            else
            {
                throw new ArgumentException();
            }

            state.Add(model.ID.ToString(), model);

            return model;

        }
    }

}
