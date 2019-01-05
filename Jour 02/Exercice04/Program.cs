using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping;
            shopping = new List<string>()
            {
                "Carottes", "Oignons", "Pommes de terre", "Salade", "Tomates"
            };
                        

            foreach (string shoppi in shopping)
            {
                Console.WriteLine(shoppi);
            }
        }
    }
}
