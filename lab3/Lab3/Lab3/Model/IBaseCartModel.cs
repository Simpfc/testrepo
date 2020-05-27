using System;

namespace Lab3.Model
{
    public interface IBaseCartModel
    {
        Guid ID { get; set; }
        int type { get; set; }
        int price { get; set; }
        bool blocked { get; set; }
        int GetPassedAmount();
        int GetDeclinedAmount();
        void Withdraw();
        bool HasAccess();
        void Block();
        void UnBlock();
        int GetCartType();
        int GetPrice();
    }
}
