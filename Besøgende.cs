class Besøgende
{

  private List<Person> BesøgendeListe = new List<Person>();

  //Constructor
  public Besøgende() { }

  public void OpretBesøgende(string navn, string begrundelse, DateTime starttid, DateTime sluttid)
  {
    BesøgendeListe.Add(new Person(navn, begrundelse, starttid, sluttid));
  }

  public void PrintBesøgende()
  {
    foreach (Person n in BesøgendeListe)
    {
      Console.WriteLine(n.Name);
    }
  }
}
