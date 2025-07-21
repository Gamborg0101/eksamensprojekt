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


}