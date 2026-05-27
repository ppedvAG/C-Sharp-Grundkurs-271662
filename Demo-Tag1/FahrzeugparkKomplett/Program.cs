namespace Fahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            Schiff schiff = new Schiff("Titanic", 50000, 1000000, Schiff.SchiffsTreibstoff.Dampf);
            PKW pkw = new PKW("BMW", 250, 50000, 4);
            Flugzeug flugzeug = new Flugzeug("Boeing 747", 900, 150000000, 416);
            Container container = new Container("BigContainer");

            Console.WriteLine(BeladeWennBeladbar(schiff, pkw)?.LadungsInfo());
            Console.WriteLine(BeladeWennBeladbar(schiff, flugzeug)?.LadungsInfo());
            Console.WriteLine(BeladeWennBeladbar(flugzeug, pkw)?.LadungsInfo());
            Console.WriteLine(BeladeWennBeladbar(flugzeug, container)?.LadungsInfo());
            container.Entlade();
            Console.WriteLine(container.LadungsInfo());
            Console.WriteLine(BeladeWennBeladbar(schiff, container)?.LadungsInfo());
        }

        static IBeladbar BeladeWennBeladbar(Object o1, Object o2)
        {
            if (o1 is IBeladbar && o2 is Fahrzeug)
            {
                ((IBeladbar)o1).Belade(o2 as Fahrzeug);
                return o1 as IBeladbar;
            }
            if (o2 is IBeladbar && o1 is Fahrzeug)
            {
                (o2 as IBeladbar).Belade((Fahrzeug)o1);
                return (IBeladbar)o2;
            }
            Console.WriteLine("Keines der Objekte ist beladbar oder ein Fahrzeug.");
            return null;
        }
    }
}