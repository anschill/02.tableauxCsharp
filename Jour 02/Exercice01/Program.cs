using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week;

            week = new string[]
            {
                "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"
            };
/*
            int i = 0;

            while (i < week.Length)
           {
                Console.WriteLine(week[i]);
                i++;
            }*/

            foreach (string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}