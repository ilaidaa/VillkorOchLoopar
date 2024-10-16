namespace VillkorOchLoopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖvningarBlandat.AskingFootball();
            //ÖvningarBlandat.AskingTemperature();
            //Omvandlaren.Calculator();
            //RäknaTill100.Counting();
            //Multiplikationstabellen.Multiplication();
            //BishBosh.Do();

            

            //Övning Labyrinten
            int size = 3; //int size = 3;: Flyttas utanför while-loopen så att variabeln inte nollställs till 3 varje gång loopen börjar om.

            while (true) 
            {
                Console.Clear();
            
                Labyrinten.DrawSquare(size);

                ConsoleKeyInfo key = Console.ReadKey(); //Console.ReadKey() väntar på att användaren ska trycka på en tangent på tangentbordet.
                                                        //När en tangent trycks, lagras information om vilken tangent det var i variabeln key, som är av typen ConsoleKeyInfo.

                if (key.Key == ConsoleKey.Z) //key: är inte speciellt variabelnamn utan key står för alla tangenter och Key står för just den tangenten användaren matar in
                                             //key:  är variabeln som innehåller all information om tangenttryckningen (ett objekt av typen ConsoleKeyInfo).
                                             //Key: de tangent som användaren trycker på
                                             //== ConsoleKey.Z : ska stämma överens med tangenten Z
                {
                    size++;
                }
                else if (key.Key == ConsoleKey.X && size > 1)
                {
                    size--;
                }
            }

        }
    }
}
