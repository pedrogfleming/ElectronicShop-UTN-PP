using ElectronicShop.Models.Accounting;
using ElectronicShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Persistence
{
    public class AccountingRepository
    {
        private decimal _TotalAmount { get; set; } = 0;

        private List<Bill> Bills { get; set; }

        /// <summary>
        /// Add a new bill to the accounting
        /// </summary>
        /// <param name="b">The bill to add</param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Add(Bill b)
        {
            var existingBill = Bills.FirstOrDefault(existingBill => b == existingBill);
            if (existingBill is null)
            {
                Bills.Add(b);
                return new RepositoryResult(true, null);
            }
            else
            {
                return new RepositoryResult(false, new List<string>() { "Bill already exists" });
            }
        }
        /// <summary>
        /// Removes a bill in the accounting
        /// </summary>
        /// <param name="BillId">The bill id to find and remove</param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Remove(Guid BillId)
        {
            var existingBill = Bills.FirstOrDefault(b => b.Id == BillId);
            if (existingBill is not null)
            {
                Bills.Remove(existingBill);
                return new RepositoryResult(true, null);
            }
            else
            {
                return new RepositoryResult(false, new List<string>() { "Bill doesn´t exists" });
            }
        }
        /// <summary>
        /// Update a bill in the inventory
        /// </summary>
        /// <param name="b">The bill to Update</param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Update(Bill b)
        {
            var existingBill = Bills.FirstOrDefault(bill => bill == b);
            if (existingBill is not null)
            {
                Bills.Remove(existingBill);
                Bills.Add(b);
                return new RepositoryResult(true, null);
            }
            else
            {
                return new RepositoryResult(false, new List<string>() { "Bill doesn´t exists" });
            }
        }
    }
}
