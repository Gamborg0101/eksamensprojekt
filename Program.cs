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
    er MaxMødeTid en metode? er det ikke smartere at manupulere den fra metoden, og ikke inde i factory? 
    Hvordan bruges polymorphi, hvis det overhovedet er det? (kan se, at jeg bruger override)    
    Snak med Niels om: 
    Medarbejder factory logik? 
    MaxMødeTid 
    Validator - hvorfor laver vi det egenligt til et array? 

 */