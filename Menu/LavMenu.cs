
class LavMenu
{
    public string[] MenuPunkt { get; set; }

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
    
    private string Input { get; set; }
    public int MenuValg()
    {
        int menuvalg = Convert.ToInt32(Input);
        return menuvalg;
    }

}