using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VillkorOchLoopar
{
    internal class ÖvningarBlandat
    {
        //Gör en metod som är public så att den kan nås från main metoden
        public static void AskingFootball()
        {         

            while (true) //Loopa i evighet för att ge användaren en annan chans
            {
                Console.WriteLine("Är Hammarby Sveriges bästa lag? Skriv ja/nej. Skriv a för att avsluta programmet"); //Frågan
                string answer = Console.ReadLine(); //Spara användarens svar

                if (answer.ToLower() == "ja") //ToLower används för att göra all inmatat från användaren till små bokstäver
                {
                    Console.WriteLine("Helt rätt!");
                }
                else if (answer.ToLower() == "nej")
                {
                    Console.WriteLine("Väldigt fel");
                }
                else if(answer == "a")
                {
                    Console.WriteLine("Programmet avslutas ... ");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Fel inmatning skriv ja eller nej"); //Denna rad finns för att hantera ifall användaren skriver någonting annat än ja eller nej
                }
                Console.ReadKey();
                Console.Clear();

            }
        }















        //Gör den public och static för att den ska nås från main
        public static void AskingTemperature()
        {
            //Jag skapar variablerna men ger inte de ett värde i början för att värdet ska jag ge i de två while loopen nedan
            double answerS; 
            double answerJ;

            //För första frågan loopa tills användaren ger ett godkänt svar, vilket är en siffra och inget annat.
            while (true) 
            {
                Console.Write("1. Vad är temperaturen i Svedala? "); //Console.Write för designens skull. Då skriver användaren svaret på samma rad
               if(double.TryParse(Console.ReadLine(), out answerS)) //TryParse är en metod som används när man försöker konvertera och då använder man också out som ska ge ett konverterat tal förhoppningsvis
                                                                    //Console.ReadLine ger alltid en sträng tillbaka därför behöver man ibland konvertera
                {
                    break; //break används för att gå ut ur en loop medan Environment.Exit(0) används för att avsluta programmet helt.
                }
                else
                {
                    Console.WriteLine("Fel inmatning. Skriv en temperatur.");
                    Thread.Sleep(2000); //Detta är en kod som gör så att programmet segar i antal som finns i parentesen
                    Console.Clear(); //Detta är en kod som rensar hela skärmen. Den kommer efter Thread.Sleep så att användaren hinner läsa meddelandet.
                }
            }

            //För andra frågan oopa tills användaren ger ett godkänt svar, vilket är en siffra och inget annat.
            while (true)
            {
                Console.Write("2. Vad är temperaturen i Jukkasjärvi? ");
                if (double.TryParse(Console.ReadLine(), out answerJ)) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel inmatning. Skriv en temperatur.");
                    Thread.Sleep(2000); //Detta är en kod som gör så att programmet segar i antal som finns i parentesen
                    Console.Clear(); //Detta är en kod som rensar hela skärmen. Den kommer efter Thread.Sleep så att användaren hinner läsa meddelandet.
                }
            }


            Console.WriteLine();//Mellanslag för designen. Det blir mellanrum mellan frågorna och svaren

            //KAlkylera svaret baserat på användarens svar
            if (answerS < answerJ)
            {
                Console.WriteLine("Det är kallare i Svedala än i Jukkasjärvi.");
            }
            else if (answerS > answerJ)
            {
                Console.WriteLine("Det är kallare i Jukkasjärvi än i Svedala.");
            }
            else
            {
                Console.WriteLine("Temperaturen är lika i både Svedala och Jukkasjärvi"); //Ifall inmatningen är densamma
            }

        }
    }
}
