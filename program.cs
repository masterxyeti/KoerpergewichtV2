using System;

namespace KoerpergewichtV2

{
    class Program
    {
        static void Main(string[] args)
        {
            double groeße, koerpergewicht;
            string geschlecht;

            Console.WriteLine("GEWICHTSBERECHNUNG(BROCA-Methode)\n");
            Console.Write("Sind Sie ein Mann/ Frau/ Divers?(m,w,d): ");
            geschlecht = Convert.ToString(Console.ReadLine());
            
            Console.Write("Geben Sie bitte ihre Körpergröße(in cm) ein: ");
            groeße = Convert.ToDouble(Console.ReadLine());
            koerpergewicht = 0;
            Console.WriteLine("\n");
            switch (geschlecht)
            {
                case "m":
                    koerpergewicht = (groeße - 100) * 0.9;
                    break;

                case "w":
                    koerpergewicht = (groeße - 100) * 0.85;
                    break;

                case "d":
                    koerpergewicht = (groeße - 100) * 0.95;
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe! \n");
                    break;
            }
            
            Console.WriteLine("Ihr Normalgewicht beträgt {0}Kg bei einer Körpergröße von {1} cm", koerpergewicht, groeße);

            Console.ReadKey();
        }
    }
}
