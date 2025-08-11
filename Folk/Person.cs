namespace eksamensprojekt.Folk;

public abstract class Person
{
    public int Id { get; }
    public string Name { get; set; }
    public string Begrundelse { get; set; }
    public DateTime Starttidspunkt { get; set; }
    public DateTime Sluttidspunkt { get; set; }
    public abstract TimeSpan MaxMødeTid();
    private static int _currentId = 1;
    
    //Protected - ellers kan Id ikke sættes i Medarbejder når den laves i MedarbejderFactory. 
    protected Person()
    {
        Id = IdGenerator();
    }
    private static int IdGenerator()
    {
        return _currentId++;
    }
}