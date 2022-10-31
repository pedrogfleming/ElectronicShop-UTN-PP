using ElectronicShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace ElectronicShop.Models.Accounting
{
    public class Bill
    {
        public Bill(Client client, DateTime dateOfSale, decimal totalAmount, Dictionary<Guid, int> itemOrders)
            :this(Guid.Empty,client,dateOfSale,totalAmount,itemOrders)
        {
        }
        public Bill(Guid id, Client client, DateTime dateOfSale, decimal totalAmount, Dictionary<Guid, int> itemOrders)
        {
            Id = id;
            Client = client;
            DateOfSale = dateOfSale;
            TotalAmount = totalAmount;
            ItemOrders = itemOrders;
        }

        public Guid Id { get; set; }
        public Client Client { get; set; }
        public DateTime DateOfSale { get; set; }
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// A dictionary of the Ids of the products and quantity selled
        /// </summary>
        public Dictionary<Guid,int> ItemOrders { get; set; }

        public static bool operator ==(Bill b1, Bill b2)
        {
            return b1.Id == b2.Id;
        }
        public static bool operator !=(Bill b1,Bill b2)
        {
            return !(b1 == b2);
        }
    }
}
