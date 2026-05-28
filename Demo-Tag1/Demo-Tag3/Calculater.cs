using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Tag3
{
    public static class Calculator
    {
        public enum Rechenoperation
        {
            Addition = 1,
            Subtraktion,
            Multiplikation,
            Division
        }

        // public Funktion zum Berechnen, kann von überall verwendet werden.
        public static double Berechne(double a, double b, Rechenoperation op)
        {
            switch (op)
            {
                case Rechenoperation.Addition:
                    return a + b;
                case Rechenoperation.Subtraktion:
                    return a - b;
                case Rechenoperation.Multiplikation:
                    return a * b;
                default:
                    if (b == 0)
                        return double.NaN;
                    else
                        return a / b;
            }
        }

        // Funktion überladen
        public static double Berechne(double a, double b, int op)
        {
            return Berechne(a, b, (Rechenoperation)op);
        }

        public static double Berechne(double a, double b,double c, Rechenoperation op = Rechenoperation.Addition)
        {
            switch (op)
            {
                case Rechenoperation.Addition:
                    return a + b+c;
                case Rechenoperation.Subtraktion:
                    return a - b-c;
                case Rechenoperation.Multiplikation:
                    return a * b*c;
                default:
                    if (b == 0 || c == 0)
                        return double.NaN;
                    else
                        return (a / b) / c;
            }
        }

        // params array
        public static double Berechne(Rechenoperation op, params double[] zahlen)
        {
            double ergebnis;
            switch (op)
            {
                case Rechenoperation.Addition:
                    ergebnis = zahlen.Sum();
                    break;
                case Rechenoperation.Subtraktion:
                    ergebnis = zahlen[1];
                    for(int i = 1; i <zahlen.Length; i++)
                    {
                        ergebnis -= zahlen[i];
                    }
                    break;
                case Rechenoperation.Multiplikation:
                    ergebnis = zahlen[1];
                    for (int i = 1; i < zahlen.Length; i++)
                    {
                        ergebnis *= zahlen[i];
                    }
                    break;
                default:
                    ergebnis = zahlen[1];
                    for (int i = 1; i < zahlen.Length; i++)
                    {
                        if(zahlen[i] == 0) 
                            return double.NaN;   
                        ergebnis = ergebnis / zahlen[i]; // Kurzschreibweise ergebnis /= zahlen[i]
                    }
                    break;
            }
            return ergebnis;
        }
    }

    public class Rechnung
    {
        public double Zahl1 { get; set; }

        public double Zahl2 { get; set; }

        public double Ergebnis { get; set; }

        public Calculator.Rechenoperation Op { get; set; }

        public Rechnung(double zahl1, double zahl2, Calculator.Rechenoperation rechenoperation, double ergebnis)
        {
            Zahl1 = zahl1;
            Zahl2 = zahl2;
            Op = rechenoperation;
            Ergebnis = ergebnis;
        }

        public override string ToString()
        {
            switch (Op)
            {
                case Calculator.Rechenoperation.Addition:
                    return $"{Zahl1} + {Zahl2} = {Ergebnis}";
                case Calculator.Rechenoperation.Subtraktion:
                    return $"{Zahl1} - {Zahl2} = {Ergebnis}";
                case Calculator.Rechenoperation.Multiplikation:
                    return $"{Zahl1} * {Zahl2} = {Ergebnis}";
                default:
                    return $"{Zahl1} / {Zahl2} = {Ergebnis}";
            }
        }
    }
}
