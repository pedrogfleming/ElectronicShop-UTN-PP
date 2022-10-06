using ElectronicShop.Models.Accounting;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tienda_Electronica.GeneralView
{
    public class BillView
    {
        public BillView(Bill b)
        {
            BillId = b.Id;
            ClientId = b.Client.Id;
            Name = b.Client.Name;
            LastName = b.Client.LastName;
            Cuil = b.Client.Cuil;
            DateOfSale = b.DateOfSale;
            TotalAmount = b.TotalAmount;
        }
        /// <summary>
        /// Converts a list of bills to a list of bills views 
        /// to display in a datagrid view with all the info
        /// </summary>
        /// <param name="bills">The list of bills to map</param>
        /// <returns>A new list of BillView</returns>
        public static List<BillView> MapSales(List<Bill> bills)
        {
            return bills.Select(b=> new BillView(b)).ToList();
        }
        public Guid BillId { get; init; }
        public Guid ClientId { get; init; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cuil { get; set; }
        public DateTime DateOfSale { get; init; }
        public decimal TotalAmount { get; init; }
    }
}
