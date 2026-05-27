using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
	internal interface IBeladbar
	{
		// Eigenschaft GeladenesFahrzeug vom Typ Fahrzeug
		Fahrzeug GeladenesFahrzeug { get; }

		// Methoden zum Beladen und Entladen
		void Belade(Fahrzeug fahrzeug);
		
		Fahrzeug Entlade();

		string LadungsInfo();

	}
}
