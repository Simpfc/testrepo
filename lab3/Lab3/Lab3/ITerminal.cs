using System;
using Lab3.Model;
using Lab3.Carts;

namespace Lab3
{
    public interface ITerminal
    {
        bool CheckAccess(IBaseCartModel cart);
        //IBaseCartModel pass(IBaseCartModel cart);
        IBaseCartModel Create(ICartDTO dto);
        void BlockCart(IBaseCartModel cart);
        void UnBlockCart(IBaseCartModel cart);
        void Withdraw(IBaseCartModel cart);
        IBaseCartModel GetCartByID(Guid id);
    }
}
