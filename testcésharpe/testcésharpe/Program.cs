using System;

namespace testcésharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour veuillez choisir un nombre.");
            Boolean flag = false;
            while(flag == false){
            string saisieUn = Console.ReadLine();
            Console.WriteLine("Vous avez saisi : " + saisieUn + " etes vous d'accord ? ");
                Console.WriteLine("Veuillez ecrire oui ou non.");
                string valide = Console.ReadLine();
                if(valide == "oui") {
                    flag = true;
                }else if(valide == "non")
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
            //Console.ReadLine();
        }
    }
}
