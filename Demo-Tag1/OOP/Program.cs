namespace OOP
{
    using Fahrzeugpark;
    using System.Drawing;

    class Program
    {
        public static void Main(string[] args)
        {
            #region tag3
            //Fahrzeug fahrzeug = new Fahrzeug();
            //Fahrzeug fahrzeug2 = new Fahrzeug();


            //fahrzeug.Farbe = Color.Magenta;
            //fahrzeug.Geschwindigkeit = 10;

            //fahrzeug2.Farbe = Color.Red;
            //fahrzeug2.Geschwindigkeit = 50;

            //Console.WriteLine("Fahrzeug hat Farbe " + fahrzeug.Farbe.Name + " und Geschwindigkeit " + fahrzeug.Geschwindigkeit);
            //Console.WriteLine("Fahrzeug2 hat Farbe " + fahrzeug2.Farbe.Name + " und Geschwindigkeit " + fahrzeug2.Geschwindigkeit);
            //fahrzeug.Geschwindigkeit = -10;
            //Console.WriteLine("Fahrzeug hat Farbe " + fahrzeug.Farbe.Name + " und Geschwindigkeit " + fahrzeug.Geschwindigkeit);

            //Fahrzeug pkw = new Fahrzeug("Audi");
            //Fahrzeug lkw = new Fahrzeug("LKW", Color.Red);
            //pkw.InfoAusgabe();
            //lkw.InfoAusgabe();
            //fahrzeug.InfoAusgabe();
            //fahrzeug2.InfoAusgabe();
            #endregion

            #region tag4
            //for (int i = 0; i < 5_000; i++)
            //{
            //    Fahrzeug fahrzeug = new Fahrzeug();
            //}

            //Fahrzeug.InfoGesamt();

            // Unterschied Ref und Out

            //int summe (int a, int b, out double avg)
            //{
            //    // out Parameter müssen vor der Rückgabe einen Wert zugewiesen bekommen
            //    avg = ((double)a+b)/2;
            //    return a + b;
            //}

            //double avg;
            //int ergebnis = summe(10, 20, out avg);
            //Console.WriteLine(ergebnis);
            //Console.WriteLine(avg);

            //// out Parameter müssen in der Methode einen Wert zugewiesen bekommen, ref Parameter müssen vor der Methode einen Wert zugewiesen bekommen
            //int summe2(int a, int b, ref int anzahlSummen)
            //{
            //    // ref Parameter müssen vor der Methode einen Wert zugewiesen bekommen+
            //    anzahlSummen++;
            //    return a + b;
            //}

            //int anzahlSummen = 0;
            //ergebnis = summe2(10, 20, ref anzahlSummen);
            //Console.WriteLine(ergebnis);
            //Console.WriteLine(anzahlSummen);
            //ergebnis = summe2(10, 20, ref anzahlSummen);
            //Console.WriteLine(ergebnis);
            //Console.WriteLine(anzahlSummen);


            #endregion

            #region tag5
            // Vererbung

            // Jede Klasse erbt von der Basisklasse Object, die Methoden wie ToString, Equals, GetHashCde, GetType bereitstellt
            // Also unser Fahrzeug ist auch ein Object und hat all diese Methoden, wobei man einige sogar überschreiben kann.
            Fahrzeug fahrzeug = new Fahrzeug("BMW", Color.Blue, 100);
            Console.WriteLine(fahrzeug.GetType());
            Console.WriteLine(fahrzeug.ToString());
            Console.WriteLine(fahrzeug);
            #endregion
        }
    }
}