using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fahrzeugpark
{
    class PKW: Fahrzeug
    {
        public int AnzahlTüren {  get; set; }
        public PKW()
        {
            AnzahlTüren = 0;
        }
        public PKW (string name, Color farbe, double geschwindigkeit, int anzahlTüren) : base(name, farbe, geschwindigkeit)
        {
            AnzahlTüren = anzahlTüren;
        }

        // Override geht nicht weil sie gesealed wurde
        //public override string ToString()
        //{
        //    return $"PKW {Name} ";
        //}

    }
}
