using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___Code_First.Models
{
    public class ManageAccountContext : DbContext
    {
        public  DbSet<SavingAccount> SavingAccounts { get; set; }
        public DbSet<Person> Persons { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=ManageAccount;Integrated Security=false;User ID=sa;Password=MedSQLserver91*;Encrypt=true;TrustServerCertificate=true"); 
        }   

    } 
}
