using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice08
{
    class Program
    {
        enum week
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi ,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {
            week Lundi = (week)1;
            Console.WriteLine("Index 1 = " + Lundi);

            Console.WriteLine("\n");

            Console.WriteLine(Enum.GetName(typeof(week), 4)); 

        }
    }
}
