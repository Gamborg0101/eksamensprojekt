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
    public int maxMødeTid { get; set; }


    /*Constructor*/
    public Person()
    {
        Id = IdGenerator();
        maxMødeTid = 0; // fx 1 time som standard
    }

    /*Custom constructor*/
    public Person(string name, string begrunelse, DateTime starttidspunkt, DateTime sluttidspunkt)
    {
        Id = IdGenerator();
        Name = name;
        Begrundelse = begrunelse;
        Starttidspunkt = starttidspunkt;
        Sluttidspunkt = sluttidspunkt;
    }

    private static int currentId = 1;

    public static int IdGenerator()
    {
        return currentId++;
    }

    /*Tjekker om mødetiden overskredet i forhold til deres tilladte mødetid*/
    public virtual bool TjekMødeTid(DateTime start, DateTime slut)
    {
        TimeSpan diff = slut - start;
        Console.WriteLine(diff.Hours);
        return diff.TotalHours <= maxMødeTid;
    }
}