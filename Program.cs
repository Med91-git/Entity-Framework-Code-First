using EntityFramework___Code_First.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework___Code_First
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Instancier le serveur de BDD 

            using (var context = new ManageAccountContext()) 
            {

                context.Database.EnsureDeleted();   

                context.Database.EnsureCreated();

                // Créer les tables de la BDD (instances des classes) 

                SavingAccount compteA = new SavingAccount
                {
                    Amount = 2000000,
                    SavingRate = 0.05M
                };

                SavingAccount compteB = new SavingAccount
                {
                    Amount = 250000,
                    SavingRate = 0.15M
                };

                SavingAccount compteC = new SavingAccount
                {
                    Amount = 10000000,
                    SavingRate = 0.02M
                };

                Person richard = new Person
                {
                    Name = "Richard"
                };

                richard.SavingAccounts = new List<SavingAccount> 
                {
                    compteA,
                    compteB,
                    compteC,

                };

                // Ajouter les tables à la BDD   

                context.Add(richard); 

                // Sauvegarder toutes les opérations effectuées en BDD

                context.SaveChanges(); 

            }



        }
    }
}
