namespace eksamensprojekt.Folk;

using Input;

public class PersonManager
{
   private readonly List<Person> _besøgendeListe = new();
   private readonly Validator _validate = new();

   //Tager brugerinput - Laver objekt og tilføjer enten medarbejder eller besøgende
   public void TilføjPerson(int valg)
   {
      switch (valg)
      {
         case 1:
            {
               BesøgendeFactory besøgende = new BesøgendeFactory();
               OpretBesøgende(besøgende.LavBesøgende());
               break;
            }
         case 2:
            {
               MedarbejderFactory medarbejder = new MedarbejderFactory();
               OpretBesøgende(medarbejder.LavMedarbejder());
               break;
            }
         default:
            Console.WriteLine("Ugyldigt valg");
            break;
      }
   }
   //Opretter objekt ind på liste - polymorfi - Her er person enten en Besøgende eller Medarbejder, men listen er af typen Person.
   private void OpretBesøgende(Person person)
   {
      _besøgendeListe.Add(person);
   }

   public void SletBesøgende()
   {
      if (_besøgendeListe.Count == 0)
      {
         Console.WriteLine("Listen er tom!");
         return;
      }

      Person fundetId = _validate.LæsBrugerIntInputSletMenu(_besøgendeListe);
      Console.WriteLine($"Registrering - {fundetId.Id} - er blevet slettet");
      _besøgendeListe.Remove(fundetId);

   }

   //Print alle funktion, hvor både besøgende og medarbejdere bliver printet
   public void PrintAlle()
   {
      foreach (Person individuel in _besøgendeListe)
      {
         Console.Write("\n");
         Console.WriteLine("Id: " + individuel.Id);
         Console.WriteLine("Navn: " + individuel.Name);
         Console.WriteLine("Begrundelse: " + individuel.Begrundelse);
         Console.WriteLine("Starttidspunkt: " + individuel.Starttidspunkt.ToString("dd-MM-yyyy - HH:mm"));
         Console.WriteLine("Sluttidspunkt: " + individuel.Sluttidspunkt.ToString("dd-MM-yyyy - HH:mm"));
         Console.Write("\n");
      }
   }
}