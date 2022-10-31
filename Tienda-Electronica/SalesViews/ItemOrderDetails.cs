using ElectronicShop.Models.Products.Tags;
using System.Collections.Generic;
using System;
using ElectronicShop.Models.Products;
using ElectronicShop.MapperConfigurations;
using System.Linq;

namespace Tienda_Electronica.SalesViews
{
    /// <summary>
    /// Class to show the details of an order item selled
    /// </summary>
    public class ItemOrderDetails
    {

        public ItemOrderDetails(Product p)
        {
            Id = p.Id.Value;
            Name = p.Name;
            Price = p.Price;
            Tags = TagMapper.ConcatenateTags(p.Tags);
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int Quantity { get; set; }

        public static List<ItemOrderDetails> MapItemOrders_To_ItemOrderDetails(Dictionary<Guid, int> itemOrders, List<Product> productsCatalog)
        {
            List<ItemOrderDetails> result = new();
            foreach (var item in itemOrders)
            {
                Product searchedProduct = productsCatalog.FirstOrDefault(p => p.Id.Value == item.Key);
                if (searchedProduct is null) continue;
                ItemOrderDetails obj = new(searchedProduct);
                obj.Quantity = item.Value;
                result.Add(obj);
            }
            return result;
        }
    }
}
