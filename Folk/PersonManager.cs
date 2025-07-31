using eksamensprojekt;
namespace Folk;

public class PersonManager
{
   private List<Person> BesøgendeListe = new List<Person>();
   
   public void TilføjPerson(int valg)
   {
      if (valg == 1)
      {
         BesøgendeFactory besøgende = new BesøgendeFactory();
         OpretBesøgende(besøgende.OpretBesøgende());
      }
      else if (valg == 2)
      {
         Medarbejder medarbejder = new Medarbejder();
         OpretBesøgende(medarbejder.OpretMedarbejder());
      }
      else
         Console.WriteLine("Ugyldigt valg");
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
         Console.WriteLine("Starttidspunkt: " + individuel.Starttidspunkt.ToString("dd-MM-yyyy - HH:mm:ss"));
         Console.WriteLine("Sluttidspunkt: " + individuel.Sluttidspunkt.ToString("dd-MM-yyyy - HH:mm:ss"));
         Console.Write("\n");
      }
   }
}