using System.Diagnostics;

class Styring
{

  public void StartProgram()
  {
    int antalMenupunkter = 3;
    string[] menupunter = { "Tilføj person", "Søg person", "Vis alle" };

    for (int n = 0; n < antalMenupunkter; n++)
    {
      Console.WriteLine($"{n + 1}. {menupunter[n]}");
    }
    int brugerValg = Convert.ToInt32(Console.ReadLine());

    if (brugerValg == 1)
    {

    }
    else if (brugerValg == 2)
    {

    }
    else if (brugerValg == 3)
    {

    }
    else
    {
      Console.WriteLine("Invalid input");
    }


    //Lav en Writeline med 1, 2 og 3 - og så en readLine, efterfulgt af et if-statement
    //hvor der sker x hvis man vælger:
    // "1. Tilføj person", "2. Søg person", "3. Vis alle",

  }
}
