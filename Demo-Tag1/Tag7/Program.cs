namespace Tag7
{
    using OOP.Fahrzeugpark;
    using System.Drawing;

    class Program
    {
        static void Main(string[] args)
        {
            // Listen und andere Aufzählungstypen

            List<string> nameList = new List<string>();
            nameList.Add("Max");
            nameList.Add("Moritz");
            nameList.Add("Moritz");
            nameList.Add("Lisa");
            nameList.Remove("Moritz");
            nameList.Contains("Moritz");

            // Last in First out (LIFO) - Stack
            Stack<double> doubleStack = new Stack<double>();
            doubleStack.Push(3.14);
            doubleStack.Push(2.71);
            doubleStack.Push(1.62);
            doubleStack.Pop();// 1.62 wird entfernt
            doubleStack.Peek();// 2.71 wird zurückgegeben, aber nicht entfernt
            doubleStack.Pop();
            doubleStack.Pop();

            // First in First out (FIFO) -
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);
            intQueue.Dequeue(); // 1 wird entfernt
            intQueue.Dequeue(); // 2 wird entfernt

            // Dictionary - Schlüssel-Wert-Paare
            Dictionary<string, Fahrzeug> fahrzeuge = new Dictionary<string, Fahrzeug>();
            fahrzeuge.Add("BMW", new PKW("BMW", Color.Red, 200, 5));
            PKW VW = new PKW("VW", Color.Blue, 180, 4);
            fahrzeuge.Add(VW.Name, VW);
            fahrzeuge.Add("Mazda", new PKW("Mazda", Color.Green, 150, 4));

            fahrzeuge["BMW"].InfoAusgabe();
            fahrzeuge["VW"].InfoAusgabe();
            fahrzeuge["Mazda"].InfoAusgabe();
        }
    }
}