using System;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demander le nom de l'utilisateur
            Console.WriteLine("Quel est votre nom ?");
            string nom = Console.ReadLine();

            // Afficher un message de salutation
            Console.WriteLine($"Bonjour, {nom} ! Bienvenue dans votre première application C#.");

            // Attendre que l'utilisateur appuie sur une touche avant de fermer la console
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
