namespace SchereSteinPapier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programmieren Sie ein Schere, Stein, Papier Spiel.
            //Der User soll eines der Handzeichen wählen können.
            //Der Computer wählt per Zufall ein eigenes Zeichen. (recherchieren Sie hierzu Random für C#)
            //Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen, verloren oder ein Unentschieden hat.
            //Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.

            bool running = true;
            int AnzahlSpiele = 5;
            while (running)
            {

                AnzahlSpiele--;
                string[] Auswahl = { "Schere", "Stein", "Papier" };
                Random NPC = new Random();
                NPC.Next(0, 3);
                int NPCAuswahl = NPC.Next(0, 3); //Schere 0, Stein 1, Papier 2
                

                Console.WriteLine("Wähle Schere, Stein oder Papier");
                string SpielerAuswahl = Console.ReadLine().ToLower().Trim();

                if (SpielerAuswahl == "schere")
                {
                    if (NPCAuswahl == 0)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Unentschieden");
                    }
                    else if (NPCAuswahl == 1)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Verloren");
                    }
                    else if (NPCAuswahl == 2)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Gewonnen");
                    }
                }
                else if (SpielerAuswahl == "stein")
                {
                    if (NPCAuswahl == 0)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Gewonnen");
                    }
                    else if (NPCAuswahl == 1)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Unentschieden");
                    }
                    else if (NPCAuswahl == 2)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Verloren");
                    }
                }
                else if (SpielerAuswahl == "papier")
                {
                    if (NPCAuswahl == 0)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Verloren");
                    }
                    else if (NPCAuswahl == 1)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Gewonnen");
                    }
                    else if (NPCAuswahl == 2)
                    {
                        Console.WriteLine($"Computer: {Auswahl[NPCAuswahl]} => Unentschieden");
                    }
                }
                else
                {
                    Console.WriteLine("Bitte eine richtige Eingabe!");
                    AnzahlSpiele++;
                    
                }


                if (AnzahlSpiele == 0)
                {          
                    Console.WriteLine("Weiter Runde (Y/N)");
                    String wdh = Console.ReadLine();    //string wdh = Console.ReadLine().ToLower().Trim();
                    wdh = wdh.Trim();
                    wdh = wdh.ToLower();

                     if (wdh == "n")
                     {
                        running = false;
                     }
                     else if (wdh == "y")
                     {
                        running = true;
                        AnzahlSpiele = 5;               
                     }
                }
            }
        }




    }
}
