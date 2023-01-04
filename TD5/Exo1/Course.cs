using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    internal class Course
    {
        public static double CalculeVitesse(double nbkm, int nbMinutes)
        {
            double kmParHeure = Math.Round((nbkm * 60) / nbMinutes, 1);
            return kmParHeure;
        }

        public static int ConvertiTempsEnMinutes(String temps)
        {
            double nbMin = int.Parse(temps.Substring(0, 2)) * 60 + int.Parse(temps.Substring(3, 2));
            return (int)nbMin;
        }

        public static double NbKmPourAtteindreVitesse(int nbMin, double vitesse)
        {
            double nbKm = (nbMin * vitesse)/ 60;
            return nbKm;
        }
        public static int NbMinPourAtteindreVitesse(double nbKm, double vitesse)
        {
            double nbMin9 = ((nbKm * 60) / 10);
            return (int)nbMin9;

        }


    }
}
