namespace eksamensprojekt.Folk;

public abstract class Person
{
    public int Id { get; }
    public string Name { get; set; }
    public string Begrundelse { get; set; }
    public DateTime Starttidspunkt { get; set; }
    public DateTime Sluttidspunkt { get; set; }
    public abstract TimeSpan MaxMødeTid();
    private static int currentId = 1; // vigtigt at den bliver gemt på klassen og ikke instansen

    //Constructor
    public Person()
    {
        Id = IdGenerator();
    }
    private static int IdGenerator()
    {
        return currentId++;
    }
}