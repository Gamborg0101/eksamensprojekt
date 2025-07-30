namespace eksamensprojekt;

class Menupunkter
{
    public static void LavMenupunkter(string[] menupunkter)
    {
        /* Iterer over menupunkter i array */
        for (int n = 0; n < menupunkter.Length; n++)
        {
            Console.WriteLine($"{n + 1}. {menupunkter[n]}");
        }
    }
    public static void LavArbejdstitelPunkter(string[] ArbejdsTitelPunkter)
    {
        for (int i = 0; i < ArbejdsTitelPunkter.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {ArbejdsTitelPunkter[i]}");
        }
    }
}