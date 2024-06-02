using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___Code_First.Models
{
    public class Person
    {
        public Guid PersonId { get; set; } 
        public string Name { get; set; }
        public List<SavingAccount> SavingAccounts { get; set; }
        public Guid SavingAccountId { get; set; }

    } 
}
