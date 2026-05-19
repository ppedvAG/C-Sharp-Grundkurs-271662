namespace Demo_Tag1
{
    class Program
    {
        // Formatierung Kürzel: alles makieren -> strg + k + f
        // Kommentare: strg + #
        static void Main(string[] args)
        {
            // Array
            int[] zahlen = new int[5];
            zahlen[0] = 1;
            zahlen[1] = 2;
            zahlen[2] = 3;
            zahlen[3] = 4;

            int[] zahlen2 = new int[] { 1, 2, 3, 4, 5 };


            // länge der Arrays vergleichen

            if (zahlen.Length == zahlen2.Length)
            {
                Console.WriteLine("Die Arrays haben die gleiche Länge.");
            }
            else if (zahlen.Length > zahlen2.Length)
            {
                Console.WriteLine("zahlen ist größer als zahlen2");
            }
            else
            {
                Console.WriteLine("zahlen ist kleiner als zahlen2");
            }

            // kommt 5 in zahlen vor?
            if (zahlen.Contains(5))
            {
                Console.WriteLine("5 ist in zahlen enthalten.");
            }
            else
            {
                Console.WriteLine("5 ist nicht in zahlen enthalten.");
            }

            Console.WriteLine("Maximum: " + zahlen.Max());



            // Teilbarkeit prüfen mit modulo Operator %
            if (zahlen2[0] % 2 == 0)
            {
                Console.WriteLine($"Die erste Zahl {zahlen2[0]} in zahlen2 ist durch 2 teilbar.");
            }
            else
            {
                Console.WriteLine($"Die erste Zahl {zahlen2.First()} in zahlen2 ist nicht durch 2 teilbar.");
            }

            if (zahlen2[1] % 2 == 0)
            {
                Console.WriteLine("Die zweite Zahl in zahlen2 ist durch 2 teilbar.");
            }
            else
            {
                Console.WriteLine("Die zweite Zahl in zahlen2 ist nicht durch 2 teilbar.");
            }
        }
    }
}