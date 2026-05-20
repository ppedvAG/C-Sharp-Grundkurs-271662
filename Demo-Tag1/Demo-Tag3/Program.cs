namespace Demo_Tag3
{
    // Um Calculater. nicht schreiben zu müssen kann man mit using static Klassen einbinden
    using static Calculator;
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("5 * 10 = " + Berechne(5, 10, Rechenoperation.Multiplikation));
            // Überladene Funktion
            Console.WriteLine("5 / 10 = " + Berechne(5, 10, 4));
            Console.WriteLine("5 * 10 * 10 = " + Berechne(5, 10, 10, Rechenoperation.Multiplikation));
            Console.WriteLine("5 + 10 + 10 = " + Berechne(5, 10, 10.0));
            // ohne params muss man immer so schreiben
            double[] zahlen = new double[] {1, 2, 3, 4, 5};
            Console.WriteLine("Summe Zahlen: "+ Berechne(Rechenoperation.Addition, zahlen));

            // mit params kann ich so schreiben
            Console.WriteLine("Zahlen multipliziert: " + Berechne(Rechenoperation.Multiplikation, 1, 2, 3, 7, 4, 5, 9, 41, 1, 2, 0));
        }   
       
    }
}