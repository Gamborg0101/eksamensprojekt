namespace eksamensprojekt.Menu;
class MenuManager
{
    private string[] MenuPunkt { get; set; }
    
    public MenuManager(string[] menuPunkt)
    {
        MenuPunkt = menuPunkt;
    }

    public bool StartOgStop(string input)
    {
        return input == "start";
    }
    
    private string LavMenupunkter()
    {
        string nytPunkt = "";
        for (int i = 0; i < MenuPunkt.Length; i++)
        {
            nytPunkt += $"{i + 1}) {MenuPunkt[i]}\n";
        }
        return nytPunkt;
    }

    public void VisMenu()
    {
        Console.WriteLine(LavMenupunkter());
    }
}