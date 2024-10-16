using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillkorOchLoopar
{
    internal class Multiplikationstabellen
    {
        public static void Multiplication()
        {
            
            //Skriv ut 1- 10 på alla RADER
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(); //Efter varje gång programmet har skrivit 1-10 på raden hoppar den ner och gör samma sak
                
                //Skriv ut 1-10 på alla kolumner
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j * i + "\t"); //j * i : Multiplicera raden med kolumnen 
                                                 //\t : skapar snygga mellanrum mellan talen
                }
            }

            Console.ReadKey();//Design
        }
    }
}
