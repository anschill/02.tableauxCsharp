using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers;
            numbers = new List<int>();

            for (int number = 2; number < 7; number++)
            {
                numbers.Add(number);
                Console.WriteLine(number);
            }

            numbers.Insert(0, 1);
            numbers.Add(7);

            foreach (int number in numbers)
            { Console.WriteLine(number); }


            Console.ReadKey();
        }
    }
}
