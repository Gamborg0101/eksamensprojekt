using eksamensprojekt;

namespace Folk
{
    class Medarbejder : Person
    {
        public Medarbejder()
        {
            maxMødeTid = 4;
        }
        
        private readonly Validator validate = new Validator();
        private readonly Tidsstyring tidsKontrol = new Tidsstyring();
        
        public Medarbejder OpretMedarbejder()
        { 
            Medarbejder medarbejder = new Medarbejder();
            Console.Write("Besøgende navn: ");
            medarbejder.Name = validate.NavnKontrol(Console.ReadLine());
      
            Console.Write("Begrundelse for besøg: ");
            medarbejder.Begrundelse = validate.BegrundelsesKontrol(Console.ReadLine());;

            DateTime start = tidsKontrol.FåTidVærdi("Starttid");
            DateTime slut = tidsKontrol.FåTidVærdi("Sluttid");

            medarbejder.Starttidspunkt = start;
            medarbejder.Sluttidspunkt = slut;
         
            tidsKontrol.TjekMaxMødetid(start, slut, medarbejder.maxMødeTid);
            Console.WriteLine($"Tilføjer besøgende - {medarbejder.Name} - til besøgslisten");
            return medarbejder;
        }

        
    }
}
