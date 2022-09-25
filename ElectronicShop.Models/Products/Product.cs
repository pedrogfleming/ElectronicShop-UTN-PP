using Aspose.BarCode.Generation;
using ElectronicShop.Models.Products.Tags;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Models.Products
{
    public class Product
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags { get; set; }
        public BarcodeGenerator BarcodeGenerator { get; set; } 

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Id.Value == p2.Id.Value || p1.Name == p2.Name;
        }
        public static bool operator !=(Product p1, Product p2)
        {
            return !(p1 == p2);
        }

    }
}
