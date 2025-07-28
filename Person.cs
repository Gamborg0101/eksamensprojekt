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
    private static int currentId = 0;

    /*Constructor*/
    public Person()
    {
        Id = IdGenerator();
        maxMødeTid = 1; /*Kan som minimum booke én time*/
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