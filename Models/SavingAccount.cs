using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___Code_First.Models
{
    public class SavingAccount
    {
        public Guid AccountId { get; set; }
        public int Amount { get; set; }
        public decimal SavingRate { get; set; }

        public SavingAccount(Guid accountId, int amount, decimal savingRate)
        {
            AccountId = accountId; 
            Amount = amount;
            SavingRate = savingRate;
        } 

    }
}
