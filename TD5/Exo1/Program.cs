using System;

namespace Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmParcourus,calculmin;
            int calculehhmm,vitesse;
            Console.WriteLine("------------------");
            Console.WriteLine("COURSE A PIED");
            Console.WriteLine("------------------");
            Console.WriteLine("Nb de km parcourus :");
            kmParcourus = double.Parse(Console.ReadLine());
            Console.WriteLine("Temps(hh:mm): ");
            string tempsmin = Console.ReadLine();
            Console.WriteLine("------------------");
            Console.WriteLine("VITESSE: ");
            Console.WriteLine("------------------");
            calculehhmm = Course.ConvertiTempsEnMinutes(tempsmin);
            calculmin = Course.CalculeVitesse(kmParcourus, calculehhmm);
            Console.WriteLine(calculmin + "km/h");
            Console.WriteLine(calculehhmm + "min");
            Console.WriteLine("Vitesse à atteindre: ");
            vitesse = int.Parse(Console.ReadLine());
            double resultat = Math.Round(Course.NbKmPourAtteindreVitesse((int)calculehhmm, vitesse), 1);
            Console.WriteLine("Pour avoir une allure moyenne de "+ vitesse+"km/h \n"+
                "-Avec le meme temps, il faut faire "+ resultat + "\n progres de"+ Math.Round((resultat- kmParcourus), 1) +"km (en +)");
            Console.WriteLine("- Avec la meme distance, il faut faire " + Course.NbMinPourAtteindreVitesse(kmParcourus, vitesse) + "min" + "\n progres de "+
                (calculehhmm - Course.NbMinPourAtteindreVitesse(kmParcourus, vitesse)) + "min (en -)");


            //Console.WriteLine(ConvertiTempsEnMinutes("01:25"));

        }

      

    }
}
