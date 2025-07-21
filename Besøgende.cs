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
    foreach (Person individuel in BesøgendeListe)
    {
      Console.Write("\n");
      Console.WriteLine("Navn: " + individuel.Name);
      Console.WriteLine("Begrundelse: " + individuel.Begrundelse);
      Console.WriteLine("Starttidspunkt: " + individuel.Starttidspunkt.ToString("dd-MM-yyyy HH:mm:ss"));
      Console.WriteLine("Sluttidspunkt: " + individuel.Sluttidspunkt.ToString("dd-MM-yyyy HH:mm:ss"));
      Console.Write("\n");
    }
  }
}
