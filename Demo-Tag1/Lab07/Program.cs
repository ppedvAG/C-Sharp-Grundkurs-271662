namespace Lab07
{
    using Fahrzeugpark;
    using System.Drawing;

    class Program
    {
        public static void Main(string[] args)
        {
            //Generierung von div. Objekten (zur Überschwemmung des RAM)
           

            Fahrzeug fz1 = new Fahrzeug("BMW", 230, 25999.99);
            for (int i = 0; i < 1000; i++)
            {
                fz1 = new Fahrzeug("BMW", 230, 25999.99);
            }

            //Bsp-Aufruf der GarbageCollection
            GC.Collect();
            //Abwarten der Finalizer-Ausführungen (der Objekte)
            GC.WaitForPendingFinalizers();

            //Aufruf der statischen Methode
            Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());
        } 
    } 
}