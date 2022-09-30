using System;
namespace ElectronicShop.Models.Accounting
{
    public class Bill
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public DateTime DateOfSale { get; set; }
        public decimal TotalAmount { get; set; }

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
