using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
	//Schiff erbt von der Fahrzeug-Klasse und übernimmt deren Member
	public class Schiff : Fahrzeug, IBeladbar
	{
		//Klasseneigener Enum
		public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }

		//Klasseneigene Property
		public SchiffsTreibstoff Treibstoff { get; set; }

		// Property BeladenesFahrzeug von IBeladbar wird implementiert
		public Fahrzeug GeladenesFahrzeug { get; private set; }


		//Konstruktor mit Bezug auf den Konstruktor der Mutterklasse (base)
		public Schiff(string name, int maxG, double preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
		{
			this.Treibstoff = treibstoff;
			this.GeladenesFahrzeug = null; // Sandardwert null für GeladenesFahrzeug
		}

		//Überschreibung der Info()-Methode mit Bezug auf die Methode der Mutterklasse (base)
		public override string Info()
		{
			// Geladenes Fahrzeug wird auch ausgegeben, falls vorhanden
			return "Das Schiff " + base.Info() + $" Es fährt mit {this.Treibstoff}." +
				$"{(GeladenesFahrzeug!=null? " Geladen: "+GeladenesFahrzeug.Name:"")}";
		}

		// Überschreibung der Hupen()-Methode (pflicht weil Hupen abstrakt ist
		public override void Hupen()
		{
			Console.WriteLine("Schiff "+Name+" Hupt: Tuuut Tuuut!");
		}

		// Methode zum Beladen des Fahrzeugs von IBeladbar wird implementiert
		public void Belade(Fahrzeug fahrzeug)
		{
			// Wenn Container leer ist, wird Fahrzeug geladen
			if (GeladenesFahrzeug == null)
			{
				GeladenesFahrzeug = fahrzeug;
			}
			else
			{
				Console.WriteLine("Container ist bereits beladen.");
			}
		}

		// Methode zum Entladen des Fahrzeugs von IBeladbar wird implementiert
		public Fahrzeug Entlade()
		{
			if (GeladenesFahrzeug != null)
			{
				// Geladenes Fahrzeug wird in eine temporäre Variable gespeichert
				Fahrzeug tempFahrzeug = GeladenesFahrzeug;
				GeladenesFahrzeug = null; // Geladenes Fahrzeug wird gelöscht
				return tempFahrzeug; // Temoräre Variable wird zurückgegeben

			}
			else
			{
				Console.WriteLine("Container ist leer.");
				return null;
			}
		}

		// Methode zur Ausgabe von Objektinformationen
		public string LadungsInfo()
		{
			if (GeladenesFahrzeug != null)
				return $"Schiff {Name} ist beladen mit {GeladenesFahrzeug.Name}.";
			else
				return $"Schiff {Name} ist leer.";
		}
	}
}
