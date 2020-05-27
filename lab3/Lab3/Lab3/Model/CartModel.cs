using System;

namespace Lab3.Model
{
    public class CartModel : IBaseCartModel
    {
        public Guid ID { get; set; }
        public int price { get; set; }
        public int type { get; set; }
        public bool blocked { get; set; }
        public int passAmount { get; set; }
        public int declineAmount { get; set; }

        public int GetPrice()
        {
            return this.price;
        }

        public int GetPassedAmount()
        {
            return this.passAmount;
        }

        public int GetDeclinedAmount()
        {
            return this.declineAmount;
        }

        public virtual void Withdraw()
        {
            // code
        }

        public virtual bool HasAccess()
        {
            return this.blocked ? false : true;
        }

        public void Block()
        {
            this.blocked = true;
        }

        public void UnBlock()
        {
            this.blocked = false;
        }

        public int GetCartType()
        {
            return this.type;
        }
    }
}
