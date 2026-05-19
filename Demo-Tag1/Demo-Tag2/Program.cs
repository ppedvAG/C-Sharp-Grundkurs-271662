namespace Demo_Tag2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Kopfgesteuerte Schleifen

            //// Kopfgesteuerte Schleife: for, while
            //// Zahlen von 1 bis 10 ausgeben
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// While Schleife mit gleicher Logik
            //int j = 1;
            //while (j <= 10)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}
            #endregion

            #region Fußgesteuerte Schleifen
            //// Fußgesteuerte Schleife: do-while
            //do
            //{
            //    j--;
            //    Console.WriteLine(j);

            //} while (j > 0);
            #endregion

            #region Schleifen mit Arrays
            //// Verwendung mit Arrays bei for Schleifen
            //int[] zahlen = new int[] { 1, 2, 3, 4, 5 , 4, 56, 64};

            //for (int i = 0; i < zahlen.Length; i++)
            //{
            //    if (zahlen[i] % 2 == 0)
            //    {
            //        Console.WriteLine($"Die Zahl {zahlen[i]} an Index {i} ist durch 2 teilbar.");
            //    }
            //}
            //Console.ReadKey();
            //// foreach Schleife: speziell für Collections (Arrays, Listen, ...)  iteriert automatisch über alle Elementn
            //foreach(int zahl in zahlen)
            //{
            //    if(zahl%2 != 0)
            //    {
            //        Console.WriteLine($"Die Zahl {zahl} ist nicht durch 2 teilbar.");
            //    }
            //}


            #endregion

            #region Enums und Switch
            // Enums: Aufzählungstypen, um eine Gruppe von benannten Konstanten zu definieren

            BevradgeType[] bevradges = new BevradgeType[3];
            Console.WriteLine("Geben Sie 3 Bevradges ein: \n" +
                "Hot: 0\n" +
                "Cold: 1 \n" +
                "Alcoholic: 2");
            int input;
            
            for (int i = 0; i < bevradges.Length; i++) {
                if (int.TryParse(Console.ReadLine(), out input) && i>=0 && i <3) {
                    bevradges[i] = (BevradgeType)input;
                }
            }

            foreach (BevradgeType b in bevradges)
            {
                switch(b)
                {
                    case BevradgeType.Hot:
                        Console.WriteLine("Achtung heiß!");
                        break;
                    case BevradgeType.Alcoholic:
                        Console.WriteLine("Achtung Alkohol!");
                        break;
                    default:
                        Console.WriteLine("Prost!");
                        break;
                }
            }

            // auf Integer von Enum zugreifen
            Console.WriteLine($"Der Integer Wert von {BevradgeType.Cold} ist {(int)BevradgeType.Cold}");


            #endregion


        }
        enum BevradgeType
        {
            Hot, Cold, Alcoholic
        } 
    }
}