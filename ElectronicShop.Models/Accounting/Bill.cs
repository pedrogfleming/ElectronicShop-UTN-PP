using System;
namespace ElectronicShop.Models.Accounting
{
    public class Bill
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public DateTime DateOfSale { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
