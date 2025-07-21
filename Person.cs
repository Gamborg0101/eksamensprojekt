class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Begrundelse { get; set; }
    public DateTime Starttidspunkt { get; set; }
    public DateTime Sluttidspunkt { get; set; }

    public Person() { }

    public Person(string name, string begrunelse, DateTime starttidspunkt, DateTime sluttidspunkt)
    {
        Name = name;
        Begrundelse = begrunelse;
        Starttidspunkt = starttidspunkt;
        Sluttidspunkt = sluttidspunkt;
    }

    public void PrintPerson()
    {
        Console.WriteLine($"Navn: {Name} og id: {Id}");
    }
}