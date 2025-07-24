class Besøgende : Person
{

  private List<Person> BesøgendeListe = new List<Person>();

  //Constructor
  public Besøgende()
  {
    maxMødeTid = 1;
  }

  public void OpretBesøgende(Person person)
  {
    BesøgendeListe.Add(person);
  }

  public void PrintBesøgende()
  {
    foreach (Person individuel in BesøgendeListe)
    {
      Console.Write("\n");
      Console.WriteLine("Id: " + individuel.Id);
      Console.WriteLine("Navn: " + individuel.Name);
      Console.WriteLine("Begrundelse: " + individuel.Begrundelse);
      Console.WriteLine("Starttidspunkt: " + individuel.Starttidspunkt.ToString("dd-MM-yyyy HH:mm:ss"));
      Console.WriteLine("Sluttidspunkt: " + individuel.Sluttidspunkt.ToString("dd-MM-yyyy HH:mm:ss"));
      Console.Write("\n");
    }
  }
}
