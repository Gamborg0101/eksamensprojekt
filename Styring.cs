using System.Collections;

class Styring
{
    private Besøgende besøgende = new Besøgende();

    /*Enums for at undgå magic numbers*/
    /*Converteres til int, så det svarer til brugerens indtastning*/
    /*Tiløj = 1 - ændrer enum'ets værdi, så det ikke starter fra 0*/
    enum MenuValg
    {
        Tilføj = 1,
        Søg = 2,
        Vis = 3,
        AfslutProgram = 4
    }


    enum ArbejdsTitler
    {
        Besøgende = 1,
        Medarbejder = 2,
    }

    public void StartProgram()
    {
        bool kørProgram = true;
        while (kørProgram)
        {
            /*Menupunkter der bruges*/
            string[] menupunkter = { "Tilføj person", "Søg person", "Vis alle", "Afslut program" };
            Menupunkter.LavMenupunkter(menupunkter);

            string[] arbejdsTitler = { "Udefrakommende", "Medarbejder" };

            Person person = null;

            /*Brugervalg - tilføj - navn */
            int brugerValg = Convert.ToInt32(Console.ReadLine());

            if (brugerValg == (int)MenuValg.Tilføj)
            {
                /*Defination af arbejdstitel*/
                Console.WriteLine("Hvilken titel har personen?");
                for (int i = 0; i < arbejdsTitler.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {arbejdsTitler[i]}");
                }
                int titelValg = Convert.ToInt32(Console.ReadLine());

                if (titelValg == (int)ArbejdsTitler.Besøgende)
                    person = new Besøgende();
                else if (titelValg == (int)ArbejdsTitler.Medarbejder)
                    person = new Medarbejder();
                else
                {
                    Console.WriteLine("Ugyldigt titelvalg.");
                    return;
                }

                /*Brugervalg - tilføj - navn */
                Console.Write("Hvad hedder den besøgende: ");
                string navn = Console.ReadLine();
                InputKontrol.NavnKontrol(navn);
                person.Name = navn;


                /*Brugervalg - tilføj - begrundelse */
                Console.WriteLine("Hvad er grunden for besøgt?");
                string begrundelse = Console.ReadLine();
                InputKontrol.BegrundelsesKontrol(begrundelse);
                person.Begrundelse = begrundelse;

                /*Brugervalg - tilføj - starttidspunkt*/
                Console.WriteLine("Hvad er starttidspunktet? (f.eks. 12:00 eller 13:15) - kun incrementer af 15 minutter");
                DateTime starttidspunkt = Convert.ToDateTime(Console.ReadLine());
                Tidsstyring.TidsKontrol(starttidspunkt);

                /*Brugervalg - tilføj - sluttidspunkt*/
                Console.WriteLine("Hvad er sluttidspunktet? (f.eks. 12:00 eller 13:15) - kun incrementer af 15 minutter");
                DateTime sluttidspunkt = Convert.ToDateTime(Console.ReadLine());
                Tidsstyring.TidsKontrol(sluttidspunkt);

                if (!Tidsstyring.StartogSlutTidspunkt(starttidspunkt, sluttidspunkt))
                {
                    Console.WriteLine("Starttidspunktet er senere en sluttidspunktet");
                    return;
                }

                if (!person.TjekMødeTid(starttidspunkt, sluttidspunkt))
                {
                    Console.WriteLine($"Mødetid overskrider max tilladt tid på {person.maxMødeTid} timer.");
                    return;
                }

                /*Opretter besøgende*/
                besøgende.OpretBesøgende(person); //Opretter person besøgende objekt.
                Console.WriteLine("Besøgende tilføjet. \n");
            }

            /*Brugervalg - søg - */
            else if (brugerValg == (int)MenuValg.Søg)
            {
                Console.WriteLine("Søgning ikke implementeret endnu.");
            }

            /*Brugervalg - vis - */
            else if (brugerValg == (int)MenuValg.Vis)
            {

                besøgende.PrintBesøgende();
            }
            /*Brugervalg - afslut program*/
            else if (brugerValg == (int)MenuValg.AfslutProgram)
            {
                Console.WriteLine("Programmet afsluttes");
                kørProgram = false;
            }
            /*Ugyldigt valg */
            else
            {
                Console.WriteLine("Ugyldigt valg.");
            }
        }
    }
}
