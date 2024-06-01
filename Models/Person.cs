using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___Code_First.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public ICollection<SavingAccount> SavingAccounts { get; set; } 
        
    }
}
