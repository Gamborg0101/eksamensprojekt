namespace eksamensprojekt.Menu;
class MenuManager
{
    private string[] MenuPunkt { get; set; }
    
    public MenuManager(string[] menuPunkt)
    {
        MenuPunkt = menuPunkt;
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
        for (int i = 0; i < MenuPunkt.Length; i++)
        {
            nytPunkt += $"{i + 1}) {MenuPunkt[i]}\n";
        }
        return nytPunkt;
    }

    //Viser menupunkterne i terminalen
    public void VisMenu()
    {
        Console.Write(LavMenupunkter());
    }
}