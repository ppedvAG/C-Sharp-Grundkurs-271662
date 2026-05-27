using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
	internal class Container : IBeladbar
	{
		public string Name { get; private set; }
		public Fahrzeug GeladenesFahrzeug { get; private set; }

		// Konstruktor des Containers mit Standartwert null für GeladenesFahrzeug
		public Container(string name)
		{
			Name = name;
			GeladenesFahrzeug = null;
		}

		public void Belade(Fahrzeug fahrzeug)
		{
			// Wenn Container leer ist, wird Fahrzeug geladen
			if (GeladenesFahrzeug == null)
			{
				GeladenesFahrzeug = fahrzeug;
			}
			else
			{
				Console.WriteLine("Container ist bereits beladen mit "+GeladenesFahrzeug.Name);
			}
		}

		// Methode zum Entladen des Fahrzeugs von IBeladbar wird implementiert
		public Fahrzeug Entlade()
		{
			if(GeladenesFahrzeug!=null)
			{
				// Geladenes Fahrzeug wird in eine temporäre Variable gespeichert
				Fahrzeug tempFahrzeug = GeladenesFahrzeug;
				GeladenesFahrzeug = null; // Geladenes Fahrzeug wird gelöscht
				return tempFahrzeug; // Temoräre Variable wird zurückgegeben

			} else
			{
				Console.WriteLine("Container ist bereits leer.");
				return null;
			}
		}
		// Methode zur Ausgabe von Objektinformationen
		public string LadungsInfo()
		{
			if (GeladenesFahrzeug != null)
				return $"Container {Name} ist beladen mit {GeladenesFahrzeug.Name}.";
			else
				return $"Container {Name} ist leer.";
		}
	}
}
