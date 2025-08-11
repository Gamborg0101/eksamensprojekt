namespace eksamensprojekt;

using Menu;

class Program
{
    static void Main()
    {
        Styring programStart = new Styring();
        programStart.StartProgram();
    }
}

/*
todo 
    er MaxMødeTid en metode? Hvordan bruges polymorphi, hvis det overhovedet er det? (kan se, at jeg bruger override)
    Få styr på && samt || i forhold til, at hvis første evaluer true, hvad så?
    Hvorfor skal jeg bruge using Folk; i InputHåndtering nuhvor den er under Input?



 */