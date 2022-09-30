using Aspose.BarCode.Generation;
using ElectronicShop.Models.Products;
using ElectronicShop.Models.Products.Tags;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicShop.Persistence
{
    public class ProductRepository
    {
        private List<Product> Products { get; set; }
        // TODO Hardcoded products
        public ProductRepository()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Mouse",
                    BarcodeGenerator = new BarcodeGenerator(EncodeTypes.Code128),
                    Price = (decimal)(new Random().Next(50,1000) + new Random().NextDouble()),
                    Description = "Good quality and long live mouse",
                    Tags = new()
                    {
                        new Tag()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Black"
                        },
                        new Tag()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Small"
                        },
                        new Tag()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Durable"
                        }
                    }
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitor",
                    Price = (decimal)(new Random().Next(50,1000) + new Random().NextDouble()),
                    Description = "Good quality Monitor for Netflix series",
                    Tags = new()
                    {
                        new Tag()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Black"
                        },
                        new Tag()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Medium"
                        },
                        new Tag()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Fragil"
                        }
                    }
                },
            };
            //TODO  Qr Generator
            //foreach (var item in Products)
            //{
            //    item.BarcodeGenerator = new BarcodeGenerator(EncodeTypes.Code128, item.Name);
            //    item.BarcodeGenerator.Parameters.Barcode.XDimension.Millimeters = 1f;
            //    item.BarcodeGenerator.Save("C:\\Users\\pedro.fleming\\Desktop\\qr" + $"{item.Name}.jpg", BarCodeImageFormat.Jpeg);
            //}
        }
        /// <summary>
        /// Get all the products of the inventory or one especificed product by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>A list of products in the inventory or the especificed product</returns>
        public List<Product> Get(Guid? Id = null)
        {
            if(Id == null)
            {
                return Products;
            }
            else
            {
                return new List<Product>()
                {
                    Products.FirstOrDefault(existingProduct => existingProduct.Id.Value == Id)
                };
            }
        }

        /// <summary>
        /// Add a new product to the inventory
        /// </summary>
        /// <param name="p">The product to add</param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Add(Product p)
        {
            var existingProduct = Products.FirstOrDefault(existingProduct => p == existingProduct);
            if(existingProduct is null)
            {
                Products.Add(p);
                return new RepositoryResult(true,null);
            }
            else
            {
                return new RepositoryResult(false,new List<string>() { "Product already exists" });
            }
        }
        /// <summary>
        /// Removes a product in the inventory
        /// </summary>
        /// <param name="IdProduct"></param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Remove(Guid IdProduct)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Id.Value == IdProduct);
            if (existingProduct is not null)
            {
                Products.Remove(existingProduct);
                return new RepositoryResult(true,null);
            }
            else
            {
                return new RepositoryResult(false,new List<string>() { "Product doesn´t exists" });
            }
        }
        /// <summary>
        /// Update a product in the inventory
        /// </summary>
        /// <param name="IdProduct"></param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Update(Product p)
        {
            var existingProduct = Products.FirstOrDefault(product => product == p);
            if (existingProduct is not null)
            {
                Products.Remove(existingProduct);
                Products.Add(p);
                return new RepositoryResult(true,null);
            }
            else
            {
                return new RepositoryResult(false,new List<string>() { "Product doesn´t exist" });
            }
        }
    }
}
