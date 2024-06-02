using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___Code_First.Models
{
    public class SavingCalculator
    {

        public void CalculerSommeTotauxEpargne() 
        {
            using (ManageAccountContext context = new ManageAccountContext()) 
            {
                List<SavingAccount> comptes = context.SavingAccounts.Select((c) => c).ToList();

                List<Person> personnes = context.Persons.Where((p) => p.Name == "Richard").ToList();  
                
                // Pour chaque compte de Richard  

                // Récupérer montant initial du compte epargne de Richard 

                // Récupérer le montant du taux d'epargne du compte epargne de Richard 
                
                // Convertir le montant du taux d'epargne en valeur de pourcentage (ex pr 5 % au format : 0.05 ) -> crééer variable intermédiaire de type decimal avec arrondi 2 chiffres après la virgule

                // int ratioPourcentage = 100;
                // decimal tauxEpargneVersionPourcentage = (decimal) tauxEpargne / (decimal) ratioPourcentage;

                // Calculer le montant epargné  (montant initial * taux epargne version pourcentage)

                // Multiplier le montant epargné par le nbre de mois (ou d'année) -> *12 ou *1 (mettre les conditions)

                // Faire la somme du montant initial + montant épargné 

                // Afficher les comptes de Richard   

                foreach ( Person personne in personnes)
                {
                    Console.WriteLine($"Comptes de Mr {personne.Name} : "); 
                    Console.WriteLine();

                    foreach ( SavingAccount compte in personne.SavingAccounts) 
                    {
                        Console.WriteLine($"Taux d'épargne : {compte.SavingRate} %. Fonds déposés initialement : {compte.Amount} €"); 
                        Console.WriteLine();  
                    }

                    // Afficher le résultat des totaux des comptes dans la console  
                    //Console.WriteLine($"Totaux des montants sur tous les comptes épargnes {personne.Name} : ");
                }
            } 

        }

    }
}
