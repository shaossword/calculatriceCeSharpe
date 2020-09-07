using System;

namespace testcésharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour veuillez choisir un nombre.");
            Boolean flag = false;
            string saisieUn = Console.ReadLine();
            while (flag == false)
            {
                Console.WriteLine("Vous avez saisi : " + saisieUn + " etes vous d'accord ? ");
                Console.WriteLine("Veuillez ecrire oui ou non.");
                string valide = Console.ReadLine();
                if (valide == "oui")
                {
                    flag = true;
                }
                else if (valide == "non")
                {
                    Console.WriteLine("Choisissez un autre nombre.");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Votre entrer est incorrect recommancer.");
                    flag = false;
                }

            }
            Console.WriteLine("Veuillez choisir un deuxieme nombre.");
            string saisieDeux = Console.ReadLine();
            while (flag == false)
            {
                Console.WriteLine("Vous avez saisi : " + saisieDeux + " etes vous d'accord ? ");
                Console.WriteLine("Veuillez ecrire oui ou non.");
                string valideDeux = Console.ReadLine();
                if (valideDeux == "oui")
                {
                    flag = true;
                }
                else if (valideDeux == "non")
                {
                    Console.WriteLine("Choisissez un autre nombre.");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Votre entrer est incorrect recommancer.");
                    flag = false;
                }

            }
            Console.WriteLine("Veuillez choisir une operation.");
            string operateur = Console.ReadLine();
            int un = (int)Int64.Parse(saisieUn);
            int deux = (int)Int64.Parse(saisieDeux);
            int result;
            switch (operateur)
            {
                case "+":
                    result = un + deux;
                    Console.WriteLine("Resultat " + result);
                    break;
                case "-":
                    result = un - deux;
                    Console.WriteLine("Resultat " + result);
                    break;
                case "*":
                    result = un * deux;
                    Console.WriteLine("Resultat " + result);
                    break;
                case "/":
                    result = un / deux;
                    Console.WriteLine("Resultat " + result);
                    break;
                default:
                        Console.WriteLine("erreur.");
                    break;
            }
        }
    }
}
