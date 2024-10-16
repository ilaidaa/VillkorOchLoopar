using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillkorOchLoopar
{
    internal class BishBosh
    {
        public static void Do()
        {
            //Deklarera variabel i whileloop
            int answer;

            //Första While loop som tar emot arean av hur stor gameboardet ska vara
            while (true)
            {
                Console.WriteLine("Välkommen till Bish Bosh ! :)");
                Console.Write("Skriv in ett helttal: ");

                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel inmatning. Skriv in ett heltal."); //Hantera om användaren sriver in double eller string
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }





            //Andra while loopen som tar emot Bish tal
            int bishNr;

            while (true)
            {
                Console.Write("Skriv in ett bish tal: ");

                if(int.TryParse(Console.ReadLine(), out bishNr))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel inmatning. Skriv in ett heltal.");
                    Thread.Sleep(1500);
                    Console.Clear();                 
                }
            }





            //Trejde while loopen som tar in ett bosh värde
            int boshNr;

            while (true)
            {

                Console.Write("Skriv in ett bosh-tal: ");

                if(int.TryParse(Console.ReadLine(), out boshNr))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel inmatning. Skriv in ett heltal");
                    Thread.Sleep(1500);
                    Console.Clear(); 
                }
            }

            Console.WriteLine(); //För design





            //Skriv ut valda nummer, bish och bosh tal
            Console.WriteLine("Ditt valde nr: " + answer);
            Console.WriteLine("Ditt valda Bish nr: " + bishNr);
            Console.WriteLine("Ditt valda Bosh nr: " + boshNr);

            Console.WriteLine(); //För design






            //Loopa från 1 till användarens valde siffra
            for(int i = 1; i < answer; i++)
            {
                //VIKTIGT att denna rad kommer först
                //eftersom else if (i % bishNr == 0) eller else if (i % boshNr == 0) kommer att utlösas innan koden ens når kontrollen för både "BISH" och "BOSH",
                //så kommer det sista fallet (i % bishNr == 0 && i % boshNr == 0) aldrig att nås.
                if (i % bishNr == 0 && i % boshNr == 0) //Om talet är jämt delbart med både Bish och Bosh-talet visas ’Bish-Bosh’ istället för talet.
                                                        //&& : betyder att allt som står till höger och vänster om tecknet måste stämma
                {
                    Console.Write("BISH-BOSH\t");
                }
                else if (i % bishNr == 0) //Om talet är jämnt delbart med Bish-talet visas ‘Bish’ istället för talet
                {
                    Console.Write("BISH\t");

                }
                else if (i % boshNr == 0) //Om talet är jämnt delbart med Bosh-talet visas ‘Bosh’ istället för talet
                {
                    Console.Write("BOSH\t");
                }
                else
                {
                    Console.Write(i + "\t");
                }

                //VIKTIGT: Efter varje 10 element/siffra hoppar du ner en rad detta för att det ska bli snyggt i konsolen men också för att siffrorna inte ska råka delas upp
                if(i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }


            Console.ReadKey(); //Avslutar fint
        }
    }
}
