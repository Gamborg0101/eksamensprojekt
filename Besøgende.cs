class Besøgende
{

  private List<Person> BesøgendeListe = new List<Person>();
  //Constructor
  public Besøgende()
  {

  }

  public void OpretBesøgende()
  {
    BesøgendeListe.Add(new Person("Casper", "Vigtig information"));
    BesøgendeListe.Add(new Person("Helle", "Mere information"));

  }
  public void PrintBesøgende()
  {
    foreach (Person n in BesøgendeListe)
    {
      Console.WriteLine(n.Name);
    }
  }
}
