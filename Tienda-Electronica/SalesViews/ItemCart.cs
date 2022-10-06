using ElectronicShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronica.SalesViews
{
    public class ItemCart
    {
        public ItemCart(Guid id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// To show in a UI controller
        /// </summary>
        public string DisplayInfo => $"{Name} - Price: ${Price.ToString("#.##")} - Quantity: {Quantity}";

        public static explicit operator Product(ItemCart i)
        {
            return new Product()
            {
                Id = i.Id,
                Name = i.Name,
                Price = i.Price
            };
        }

        public static bool operator ==(ItemCart i, Product p)
        {
            return i.Id == p.Id;
        }
        public static bool operator !=(ItemCart i, Product p)
        {
            return !(i == p);
        }

    }
}
