using eksamensprojekt;
using eksamensprojekt.Folk;

namespace Folk;

public class PersonManager
{
   private readonly List<Person> BesøgendeListe = new List<Person>();
   private readonly Validator validate = new();
   
   //Laver objekt og tilføjer enten medarbejder eller besøgende ud fra brugerinput
   public void TilføjPerson(int valg)
   {
      if (valg == 1)
      {
         BesøgendeFactory besøgende = new BesøgendeFactory();
         OpretBesøgende(besøgende.IndtastBesøgende());
      }
      else if (valg == 2)
      {
         MedarbejderFactory medarbejder = new MedarbejderFactory();
         OpretBesøgende(medarbejder.IndtastMedarbejder());
      }
      else
         Console.WriteLine("Ugyldigt valg");
   }
   //Opretter objekt ind på liste
   private void OpretBesøgende(Person person)
   {
      BesøgendeListe.Add(person);
   }

   public void SletBesøgende()
   {
      Person fundetId = validate.LæsBrugerIntInputSletMenu(BesøgendeListe);
      if (fundetId != null) //Skal valider her, eller sætte Console.WriteLine ind i metoden.
      {
         BesøgendeListe.Remove(fundetId);
         Console.WriteLine("Personen er blevet slettet");
      }
   }
   
   //Print alle funktion, hvor både besøgende og medarbejdere bliver printet
   public void PrintAlle()
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