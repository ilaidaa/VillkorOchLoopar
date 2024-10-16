using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillkorOchLoopar
{
    internal class RäknaTill100
    {
        public static void Counting()
        {
            //Räkna till 100 med en while-loop
            Console.WriteLine("Räkna till 100 med en while loop och markera alla jämna tal:");

            //Ge startvärde till en variabel som du kan ha som bas i din while loop
            //I en korrekt while-loop behövs en variabel som kan uppdateras, vilket gör att loopen avslutas efter ett antal iterationer.
            //1 <= 100 kommer alltid att vara sant, så loopen skulle aldrig sluta om du skrev den direkt i while loopen
            //Variabeln number måste förändras för att villkoret i loopen ska bli falskt vid något tillfälle och bryta loopen.
            //Därför defineras den utanför while loopen
            int number = 1;

            while(number <= 100) //Loopen ska köras tills du når 100
            {
                if(number % 2 == 0) //Villkoret säger att number går att dela med 2. Svaret blir 0 det går alltså att dela med 2.
                {
                    Console.Write("[" + number + "] "); //Här skriver vi ut parenteser runt talet OM den följer vilkoret ovan, alltså går att dela med 2 
                                                           //Write är ist för WriteLine för att skriva ut siffrorna på samma rad och inte under
                }
                else
                {
                    Console.Write(number + " "); //Här skriver du ut talet utan parenteser OM den inte ä jämn.
                                                 //" " är till för att skapa mellanrum efter att siffran har skrivits ut
                }
                number++; // Öka värdet på number så att loopen går framåt annars skriver den ut 1 miljoner gånger. För att den ska kunna skriva 2, 3, 4 osv måste du skriva ++
            }

            Console.WriteLine(); //För design (ha mellanrum mellan while och for loopen
            Console.WriteLine(); //För design







            //Räkna till 100 med en for-loop
            Console.WriteLine("Räkna till 100 med en for loop och markera alla ojämna tal:");
            for(int i = 1; i <= 100; i++) //Loopa igenom från 1-100. Lägg märke till <= Detta skriv så att programmet skriver ut 100 också.
            {
                //Om talet är udda ska nedan skrivas            
                if(i % 2 != 0) //% = modula och betyder nästan dela med. Här delar jag i med 2 och säger att om svaret inte är (!=) 0 då ska följande skrivas.
                               //Något som inte kan delas med 2 är ju inte jämt utan udda
                {
                    Console.Write("[" + i + "] ");
                }
                else
                {
                    Console.Write(i + " ");//Här menar jag att alla tal förutom de som inte går att dea med 2, d.v.s. jämna tal, d ska skrivas ut som vanligt.
                                           //Skriver ut alla talen på samma rad med mellanrum därav " "
                }
            }

            Console.ReadKey(); //Användaren måste trycka på en tangent för att avsluta programmet
        }
    }
}
