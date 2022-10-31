using ElectronicShop.MapperConfigurations;
using ElectronicShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MapperConfigurations
{
    public static class BillMapper
    {
        public static Dictionary<Guid, int> MapCartProducts_To_ItemOrders(Dictionary<Product, int> cartItems)
        {
            Dictionary<Guid, int> result = new();
            foreach (var item in cartItems)
            {
                result.Add(item.Key.Id.Value, item.Value);
            }
            return result;
        }


    }
}
