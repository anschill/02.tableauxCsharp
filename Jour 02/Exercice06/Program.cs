using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06
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
            String[] week = Enum.GetNames(typeof(Week));
            foreach (String day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}