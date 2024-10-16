using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillkorOchLoopar
{
    internal class Labyrinten
    {
        //Metod 1 
        //Skriver ut en fyrkant som ska ta in size som är storleken på kvadraten
        public static void DrawSquare(int size) //Tar emot storlek i Main metoden
        {

            for (int row = 0; row < size; row++) //Loopar igenom varje rad. Alltså uppifrån ner.
                                                 //Raden kan inte vara större än size som du matar in i Main. Den är 3
            {
                Console.Write("+"); //Du skriver Write vilket betyder att det ska skrivas ut på samma rad och eftersom size är 3 skrivs den ut 3 ggr.
                                    //Den ser ut såhär i konsolen +++
                                    //MEN på rad 30 har du skrivit Console.WriteLINE vilket betyder att såfort den skriver + ska den hoppa ner en rad
                                    //och eftersom size är 3 så körs detta 3 ggr.
                                    //Därför kommer konsolen se ut såhär:
                                    //+
                                    //+
                                    //+
                for (int col = 0; col < size; col++) //Nu går vi igenom varje column alltså från höger till vänster RUTORNA i fyrkanten
                {
                    Console.Write("---+"); //Console.Write igen och den körs 3 ggr så det ser ut såhär: ---+ ---+ ---+
                                           //Tänk på att vi redan har skrivit + och varje rad börjar med plus så det ser ut såhär: + ---+ ---+ ---+
                }

                Console.WriteLine(); //Hör ihop med rad 20

                //Gör en ny loop för vi ska lägga mellanrum men också verikala streck i fyrkanten så den inte är helt platt såhär:
                //OBS: viktigt att du fortsätter i loopen och inte gör en ny
                // + ---+ ---+ ---+
                // + ---+ ---+ ---+
                // + ---+ ---+ ---+
                for (int col = 0; col < size; col++)
                {
                    Console.Write("|   "); //Varje column ska börja med | och ha tre mellanrum. Eftersom att det är write händer allt på samma rad 3 ggr (för att vi valt size 3) Då ser det ut såhär:
                                           //OBS: vi måste låta det köras i varje kolumn under oxå därför sätter vi Console.WriteLine() på rad 53.
                                           // + ---+ ---+ ---+
                                           // |    |    |   
                                           // + ---+ ---+ ---+
                                           // |    |    |
                                           // + ---+ ---+ ---+
                                           // |    |    |
                                           //Som du ser är kanterna längst ut till höger tomma för det körs bara 3 gånger där, för att fylla kanterna lägger vi "|" i ConsoleWriteLine på rad 53
                }
                Console.WriteLine("|"); //Nu ser fyrkanten ut såhär:
                                        // + ---+ ---+ ---+
                                        // |    |    |    |
                                        // + ---+ ---+ ---+
                                        // |    |    |    |
                                        // + ---+ ---+ ---+
                                        // |    |    |    |

                //Vi måste fylla undersidan och det kan du göra med en helt ny loop som är utanför denna
            }


            //Ny loop som fixar undersidan
            Console.Write("+"); // Eftersom att vi bara vill ha en rad och inte flera ska vi lägga ETT + på raden

            for (int row = 0; row < size; row++)
            {
                Console.Write("---+"); //Eftersom att size är 3 så kommer denna rad skriva ut detta: ---+ ---+ ---+
                                       //Och det blir perfekt med + tecknet vi skrev på rad 66. Då täcks underdelen av vår fyrkant oxå
            }

        }





  
   
    }
}
       



    