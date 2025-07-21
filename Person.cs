using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Transactions;

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Begrundelse { get; set; }
    public DateTime Starttidspunkt { get; set; }
    public DateTime Sluttidspunkt { get; set; }

    /*Constructor*/
    public Person() { }

    private static int currentId = 1;

    public static int IdGenerator()
    {
        return currentId++;
    }

    public Person(string name, string begrunelse, DateTime starttidspunkt, DateTime sluttidspunkt)
    {
        Id = IdGenerator();
        Name = name;
        Begrundelse = begrunelse;
        Starttidspunkt = starttidspunkt;
        Sluttidspunkt = sluttidspunkt;

    }
}