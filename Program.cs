using EntityFramework___Code_First.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EntityFramework___Code_First
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // Configurer l'encodage de la console pour UTF-8 

            Console.OutputEncoding = Encoding.UTF8;


            // Instancier le serveur de BDD 

            using (ManageAccountContext server = new ManageAccountContext())
            {

                server.Database.EnsureDeleted();

                server.Database.EnsureCreated();

                // Créer les tables de la BDD (instances des classes) 

                Person richard = new Person
                {
                    Name = "Richard"
                };

                richard.SavingAccounts = new List<SavingAccount>
                {
                    new SavingAccount {Amount = 2000000, SavingRate = 5}, 
                    new SavingAccount {Amount = 250000, SavingRate = 15},
                    new SavingAccount {Amount = 10000000, SavingRate = 2} 

                };

                // Ajouter les tables à la BDD  

                server.Add(richard);

                // Sauvegarder toutes les opérations effectuées en BDD

                server.SaveChanges();

            };

            SavingCalculator calculator = new SavingCalculator();

            calculator.CalculerSommeTotauxEpargne();  


        }

            

        
    }
}
