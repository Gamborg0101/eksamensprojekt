namespace eksamensprojekt.Menu;

class MenuManager
{
    public string[] MenuPunkter { get; }

    public MenuManager(string[] menuPunkter)
    {
        MenuPunkter = menuPunkter;
    }

    //Returner true eller false afhængigt af input for at starte eller stoppe programmet
    public bool StartOgStop(string input)
    {
        return input == "start";
    }

    //Itererer over menupunkterne, for at lave menupunktslisten
    private string LavMenupunkter()
    {
        string nytPunkt = "";
        for (int i = 0; i < MenuPunkter.Length; i++)
        {
            nytPunkt += $"{i + 1}) {MenuPunkter[i]}\n";
        }

        return nytPunkt;
    }

    //Viser menupunkterne i terminalen
    public void VisMenu()
    {
        Console.Write(LavMenupunkter());
    }
}