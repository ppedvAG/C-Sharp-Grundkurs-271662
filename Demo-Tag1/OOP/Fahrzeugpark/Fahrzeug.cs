using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fahrzeugpark
{
    // Klasse Fahrzeug beschreibt wie ein Fahrzeug aufgebaut ist
    public class Fahrzeug
    {
        // Eigenschaften von einem Fahrzeug
        public Color Farbe {  get; set; } = Color.White;
        public string Name { get; private set; } = "";

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
        public Fahrzeug() { } // Basiskonstruktor der auch existiert wenn ich ihn nicht schreibe

        // Ich kann mehrere Konstruktoren erstellen, es wird automatisch der passende aufgerufen
        // Konstruktoren werden verwendet um "Startwerte" für Eigenschaften festzulegen zB. Name
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

        // Public Methode, die ich über die Fahrzeug Objekte aufrufen kann und mir die Infos ausgibt
        public void InfoAusgabe()
        {
            Console.WriteLine($"Fahrzeug {Name} hat Farbe {Farbe.Name} und Geschwindigkeit {Geschwindigkeit}");
        }

    }
}
