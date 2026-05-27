using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
	public abstract class Fahrzeug
	{
		//Properties
		public string Name { get; set; }
		public int MaxGeschwindigkeit { get; set; }
		public int AktGeschwindigkeit { get; private set; }
		public double Preis { get; set; }
		public bool MotorLaeuft { get; set; }

		//Konstruktor mit Übergabeparametern und Standartwerten
		public Fahrzeug(string name, int maxG, double preis)
		{
			Name = name;
			MaxGeschwindigkeit = maxG;
			this.Preis = preis;
			this.AktGeschwindigkeit = 0;
			this.MotorLaeuft = false;
		}

		//Methode zur Ausgabe von Objektinformationen
		//NEU: virtual, damit sie in abgeleiteten Klassen überschrieben werden kann
		public virtual string Info()
		{
			if (this.MotorLaeuft)
				return $"{this.Name} kostet {this.Preis}€ und fährt momentan " +
					$"mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h.";
			else
				return $"{this.Name} kostet {this.Preis}€ und könnte maximal " +
					$"{this.MaxGeschwindigkeit}km/h fahren.";
		}

		//Methode zum Starten des Motors
		public void StarteMotor()
		{
			if (this.MotorLaeuft)
				Console.WriteLine($"Der Motor von {this.Name} läuft bereits.");
			else
			{
				this.MotorLaeuft = true;
				Console.WriteLine($"Der Motor von {this.Name} wurde gestartet.");
			}
		}

		//Methode zum Stoppen des Motors
		public void StoppeMotor()
		{
			if (!this.MotorLaeuft)
				Console.WriteLine($"Der Motor von {this.Name} ist bereits gestoppt");
			else if (this.AktGeschwindigkeit > 0)
				Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich " +
					$"{this.Name} noch bewegt");
			else
			{
				this.MotorLaeuft = false;
				Console.WriteLine($"Der Motor von {this.Name} wurde gestoppt.");
			}
		}

		//Methode zum Beschleunigen und Bremsen
		public void Beschleunige(int a)
		{
			if (this.MotorLaeuft)
			{
				if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
					this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
				else if (this.AktGeschwindigkeit + a < 0)
					this.AktGeschwindigkeit = 0;
				else
					this.AktGeschwindigkeit += a;

				Console.WriteLine($"{this.Name} bewegt sich jetzt mit " +
					$"{this.AktGeschwindigkeit}km/h");
			}
		}

		// abstrakte Methode Hupen
		public abstract void Hupen();

		// Statische Methode GeneriereFahrzeug
		public static Fahrzeug GeneriereFahrzeug(string name)
		{
			Random random = new Random();
			int typZahl = random.Next(3); // 0 = PKW, 1 = Schiff, 2 = Flugzeug
			switch(typZahl)
			{
				case 0: return new PKW
							(name,
							random.Next(80, 350),
							random.Next(10_000, 200_000),
							random.Next(2, 4));
					break;
				case 1:
					return new Schiff
							(name,
							random.Next(2, 90),
							random.Next(10_000, 200_000_000),
							Schiff.SchiffsTreibstoff.Diesel);
					break;
				default:
					return new Flugzeug
							(name,
							random.Next(200, 1_200),
							random.Next(100_000, 500_000_000),
							random.Next(5_000, 15_000));
					break;
			}
		}

		public override string ToString()
		{
			return $"Name: {this.Name}, Typ: {this.GetType().Name}";
		}

	}

}
