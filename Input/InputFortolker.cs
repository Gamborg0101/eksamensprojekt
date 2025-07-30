namespace eksamensprojekt.Input;

public class InputFortolker
{
    public InputFortolker(string? input)
    {
        Input = input;
    }

    private string? Input { get; set; }

    public int MenuValg()
    {
        int menuvalg = Convert.ToInt32(Input);
        return menuvalg;
    }
}