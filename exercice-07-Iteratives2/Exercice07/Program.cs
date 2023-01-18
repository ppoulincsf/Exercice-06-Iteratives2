using System;

namespace Exercice07
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ReadNumber();
      ReadUsernamePassword();
      ReadUsernamePasswordLimitedAttempts();
      GenerateRandomNumbers();
    }

    public static void ReadNumber()
    {
      const int MIN = 0;
      const int MAX = 10;

      bool success; // Indique si ce que l'usager a saisi était bien un entier.
      int number;    // Entier saisir par l'usager lorsque valide.

      // Écrit dans la console. Notez le symbole $ devant la string, nous permettant
      // d'inclure directement des variables dans la chaine de caractères.
      Console.WriteLine($"Entrez un nombre entre {MIN} et {MAX} : ");

      // Lit à partir de la console, jusqu'à ce que l'utilisateur appuie sur "Enter".
      string text = Console.ReadLine();

      // Convertit la chaine de caractères en un entier.
      // À modifier
    }

    public static void ReadUsernamePassword()
    {
      // À compléter
    }

    public static void ReadUsernamePasswordLimitedAttempts()
    {
      // À compléter
    }

    public static void GenerateRandomNumbers()
    {
      // Quantité de nombres à générer 
      const int NB_TO_GENERATE = 3000;

      // Compteurs pour la quantité de nombres entre 1 et 33, entre 34 et 66 et entre 67 et 99
      int nbBetween01And33 = 0;
      int nbBetween34And66 = 0;
      int nbBetween67And99 = 0;

      // À compléter

      // Affichage des résultats
      Console.WriteLine($"Nombre de valeurs entre 01 et 33 (inclusivement) = {nbBetween01And33}");
      Console.WriteLine($"Nombre de valeurs entre 34 et 66 (inclusivement) = {nbBetween34And66}");
      Console.WriteLine($"Nombre de valeurs entre 67 et 99 (inclusivement) = {nbBetween67And99}");
    }
  }
}
