using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fahrzeugpark
{
    // Klasse Fahrzeug beschreibt wie ein Fahrzeug aufgebaut ist
    // Fahrzeug muss abstrakt sein, da InfoAusgabe abstrakt ist
    public abstract class Fahrzeug
    {
        // Eigenschaften von einem Fahrzeug
        public Color Farbe {  get; set; } = Color.White;
        public string Name { get; private set; } = "";

        public static int AnzahlFahrzeuge { get; private set; } = 0; // statische Eigenschaft, die die Anzahl der Fahrzeuge zählt

        // Feld brauche ich, damit ich das set einschränken kann
        private double geschwindigkeit = 0;
        // Eigenschaft Geschwindigkeit, mit Überprüfung
        public double Geschwindigkeit { 
            get
            {
                return geschwindigkeit;
            } 
            set
            {
                if(value >=0)
                    geschwindigkeit = value;
            }
        }

        // Konstruktor rufe ich auf, wenn ich ein neues Objekt erstelle zB. Fahrzeug fahrzeug = new Fahrzeug()
        // mit new und dem Konstruktornamen wird der Konstruktor aufgerufen.
        // Wenn man keinen Konstruktor schreibt, ist im Hintergrund standardmäßig ein leerer Konstruktor da:
        public Fahrzeug() {
            AnzahlFahrzeuge++;
            this.Name = "Fahrzeug " + AnzahlFahrzeuge; 
        } // Basiskonstruktor der auch existiert wenn ich ihn nicht schreibe

        // Ich kann mehrere Konstruktoren erstellen, es wird automatisch der passende aufgerufen
        // Konstruktoren werden verwendet um "Startwerte" für Eigenschaften festzulegen zB. Name
        // Konstruktoren können nicht direkt aufgerufen werden, weil Fahrzeug abstrakt ist, somit kann man kein Objekt davon erstellen,
            // aber die Konstruktoren werden von den abgeleiteten Klassen verwendet
        public Fahrzeug(string name)
        {
            this.Name = name;
        }
        public Fahrzeug(string name, Color farbe): this(name)
        {
            Farbe = farbe; // this ist nicht nötig weil Farbe und Name eindeutig sind
        }

        public Fahrzeug(string name, Color farbe, double geschwindigkeit):this(name, farbe)
        {
            Geschwindigkeit = geschwindigkeit;
        }

        // abstrakte Methode, die ich über die Fahrzeug Objekte aufrufen kann und mir die Infos ausgibt
        // muss überschrieben werden.
        public abstract void InfoAusgabe();

        // Destruktor, mit Console.Writeline, um zu sehen wann Objekte gelöscht werden
        ~Fahrzeug()
        {
            Console.WriteLine(Name+" wurde gelöscht");
        }

        // Statische Methode, die ich über die Klasse aufrufen kann, ohne ein Objekt zu erstellen
        public static void InfoGesamt()
        {
            Console.WriteLine($"Insgesamt gibt es {AnzahlFahrzeuge} Fahrzeuge.");
        }

        // ToString Methode Überschreiben.
        public sealed override string ToString()
        {
            return base.ToString()+": "+Name;
        }

    }
}
