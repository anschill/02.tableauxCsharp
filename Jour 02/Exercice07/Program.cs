
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07
{
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {
            foreach (String day in Enum.GetNames(typeof(Week)))  //affiche tous les noms de l'enum Week, parcourt un tableau.
            {

                Console.WriteLine(day);

            }

            Console.WriteLine("\n");

            Console.WriteLine(Enum.GetName(typeof(Week), 4)); // récupère le nom d'un élément de l'enum 'Week', celui à l'indice 4. 
        }

    }
}
