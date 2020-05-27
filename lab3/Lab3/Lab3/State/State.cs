using System;
using System.Collections.Generic;
using Lab3.Model;

namespace Lab3.State
{
   
    public static class State
    {
        static Dictionary<Guid, IBaseCartModel> state = new Dictionary<Guid, IBaseCartModel>();
        
        public static IBaseCartModel GetCartModel(Guid id)
        {
            return state.GetValueOrDefault(id);
        }

        //public static IBaseCartModel AddCartModel(IBaseCartModel model)
        //{
        //    //return state.Add(model.ID, );
        //}
    }
}
