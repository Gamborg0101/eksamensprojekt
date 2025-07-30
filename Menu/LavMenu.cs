
class LavMenu
{
    public string[] MenuPunkt { get; set; }
    private int Input { get; set; }
    public LavMenu(string[] menuPunkt)
    {
        MenuPunkt = menuPunkt;
    }
    public string LavMenupunkter()
    {
        string nytPunkt = "";
        for (int i = 0; i < MenuPunkt.Length; i++)
        {
            nytPunkt += $"{i + 1}) {MenuPunkt[i]}\n";
        }
        return nytPunkt;
    }
    
    public int HentInput()
    {
        Console.Write("Vælg et menupunkt: ");
        Input = Convert.ToInt32(Console.ReadLine());
        return Input;
    }
    
    
    public int MenuValg()
    {
        int menuvalg = Convert.ToInt32(Input);
        if (menuvalg < MenuPunkt.Length)
        {
            return menuvalg;
        }
        return -1;
    }
}