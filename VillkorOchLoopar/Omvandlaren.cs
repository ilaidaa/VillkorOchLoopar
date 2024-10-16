using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillkorOchLoopar
{
    internal class Omvandlaren
    {
        public static void Calculator()
        {
            //Jag skapar variabeln där jag ska lagra användaren input MEN jag ger det inget värde för det ska jag göra i  whileloopen längre ner.
            double answer;


            while (true) //Denna loop kommer köras tills användaren skriver in en siffra och inget annat
            {
                Console.WriteLine("Välkommen till appen som konverterar Celsius till Fahrenheit ! :) ");
                Console.Write("Skriv in  valfritt numeriskt värde: "); //Write för designens skull, d

                if (double.TryParse(Console.ReadLine(), out answer))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel inmatning. Skriv in en siffra");
                    Thread.Sleep(2000); //Pausar programmet i 2000 milliek
                    Console.Clear(); //Rensar skärmen 
                }

            }

            Console.WriteLine(); //Mellanslag för designen

            Console.WriteLine("Svar: " + answer + " Celsius = " + (answer * 1.8 + 32) + " Fahrenheit"); //(answer * 1.8 + 32) är själva formeln att räkna u tFahrenhei som går enkelt att hitta på nätet.

            Console.ReadKey(); //Gör så att användaren måste trycka på en tangent för att programmet ska avslutas

        }


    }
}
