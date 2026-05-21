namespace OOP
{
    using Fahrzeugpark;
    using System.Drawing;

    class Program
    {
        public static void Main(string[] args)
        {
            Fahrzeug fahrzeug = new Fahrzeug();
            Fahrzeug fahrzeug2 = new Fahrzeug();


            fahrzeug.Farbe = Color.Magenta;
            fahrzeug.Geschwindigkeit = 10;

            fahrzeug2.Farbe = Color.Red;
            fahrzeug2.Geschwindigkeit = 50;

            Console.WriteLine("Fahrzeug hat Farbe " + fahrzeug.Farbe.Name + " und Geschwindigkeit " + fahrzeug.Geschwindigkeit);
            Console.WriteLine("Fahrzeug2 hat Farbe " + fahrzeug2.Farbe.Name + " und Geschwindigkeit " + fahrzeug2.Geschwindigkeit);
            fahrzeug.Geschwindigkeit = -10;
            Console.WriteLine("Fahrzeug hat Farbe " + fahrzeug.Farbe.Name + " und Geschwindigkeit " + fahrzeug.Geschwindigkeit);

            Fahrzeug pkw = new Fahrzeug("Audi");
            Fahrzeug lkw = new Fahrzeug("LKW", Color.Red);
            pkw.InfoAusgabe();
            lkw.InfoAusgabe();
            fahrzeug.InfoAusgabe();
            fahrzeug2.InfoAusgabe();


        }
    }
}