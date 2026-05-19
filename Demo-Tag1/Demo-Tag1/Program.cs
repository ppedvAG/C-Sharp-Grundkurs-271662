
// namespace, class und main methode werden automatisch im Hintergrund erstellt
// besser ist es aber, sie auszuschreiben, da ich dann außerhalb sachen machen kann.
namespace Demo_Tag1 {
    class Program {
        static void Main(string[] args)
        {
            // Ausgabe auf der Konsole
            Console.WriteLine("Hello, World!");

            



            // Kommentare für Dokumentation von Funktionen, Klassen, etc. /// <summary>...</summary>
            /// <summary>
            /// This is a local function.
            /// </summary>
            /// <params></params>
            /// <returns></returns>
            static void LocalFunction()
            {
                Console.WriteLine("This is a local function.");
            }
            // Funktion aufrufen
            LocalFunction();

            // Strings und Escaping
            // achtung bei Pfaden
            string path = "C:\\Users\\de2\\OneDrive - ppedv AG\\Anla";

            // \n neue Zeile, \t Tabulator, \\ Backslash, \" Anführungszeichen
            string text = "Das ist ein Text mit einem Zeilenumbruch.\n" +
                "Und hier geht es weiter.";


            // tryParse für Konvertierung mit Überprüfung ob die Eingabe gültig ist
            Console.WriteLine("Bitte ganze Zahl eingeben: ");
            int numberInput;
            // Parse wirft eine Exception, wenn die Eingabe ungültig ist, TryParse gibt false zurück und setzt die Ausgabevariable auf 0
            //numberInput = int.Parse(Console.ReadLine()); 

            // TryParse wir standardmäßig in einer if verwendet. der out Parameter numberInput wird überschrieben
            if (int.TryParse(Console.ReadLine(), out numberInput))
            {
                Console.WriteLine(numberInput);
            } else
            {
                Console.WriteLine("Das war keine gültige Zahl.");
            }




            //Console.WriteLine("Beliebige Taste drücken zum Beenden...");
            //Console.ReadKey();

            // Berechnung von Geschwindigkeit
            //int sekundenGes = minuten * 60 + stunden * 3600;

            int streckeGes = 4500;

            //double meterProSekunde = (double)streckeGes / sekundenGes;

            double kilometerProStunde = meterProSekunde * 3.6;

            double milesProStunde = meterProSekunde * 2.23694;
        }
    }
}