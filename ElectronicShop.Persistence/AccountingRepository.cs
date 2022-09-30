using ElectronicShop.Models.Accounting;
using ElectronicShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Persistence
{
    public class AccountingRepository
    {
        private decimal _TotalAmount { get; set; } = 0;

        /// <summary>
        /// All the bills of the shop. We use a HashSet so we only keep it unique objects
        /// </summary>
        private HashSet<Bill> Bills { get; set; }

        public AccountingRepository()
        {
            Bills = new();
        }

        /// <summary>
        /// Add a new bill to the accounting
        /// </summary>
        /// <param name="b">The bill to add</param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Add(Bill b)
        {
            b.Id = Guid.NewGuid();
            bool added = Bills.Add(b);
            if (!added)
            {
                return new RepositoryResult(false, new List<string>() { "Bill already exists" });
            }
            else
            {

                return new RepositoryResult(true, null);
            }
        }
        /// <summary>
        /// Removes a bill in the accounting
        /// </summary>
        /// <param name="BillId">The bill id to find and remove</param>
        /// <returns>True if success, false and the error details if not</returns>
        public RepositoryResult Remove(Guid billId)
        {
            int removed = Bills.RemoveWhere(b => b.Id == billId);
            if (removed > 0)
            {
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
        /// <summary>
        /// Get by id or all the bills
        /// </summary>
        /// <param name="id">Thde optional id search parameter</param>
        /// <returns>The list with all or the demanded bill</returns>
        public List<Bill> Get(Guid? id = null)
        {
            if(id is null)
            {
                return new List<Bill>(Bills);
            }
            else
            {
                Bill existingBill = Bills.FirstOrDefault(bill => bill.Id == id);
                List<Bill> bills = new();
                if(existingBill is not null) bills.Add(existingBill);                
                return bills;
            }
        }
    }
}
