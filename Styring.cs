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

    public void StartProgram()
    {
        bool kørProgram = true;
        while (kørProgram)
        {
            /*Menupunkter der bruges*/
            string[] menupunkter = { "Tilføj person", "Søg person", "Vis alle", "Afslut program" };
            Menupunkter.LavMenupunkter(menupunkter);

            /*Brugervalg - tilføj - navn */
            int brugerValg = Convert.ToInt32(Console.ReadLine());

            if (brugerValg == (int)MenuValg.Tilføj)
            {
                /*Brugervalg - tilføj - navn */
                Console.Write("Hvad hedder den besøgende: ");
                string navn = Console.ReadLine();
                InputKontrol.NavnKontrol(navn);

                /*Brugervalg - tilføj - begrundelse */
                Console.WriteLine("Hvad er grunden for besøgt?");
                string begrundelse = Console.ReadLine();
                InputKontrol.BegrundelsesKontrol(begrundelse);

                /*Brugervalg - tilføj - starttidspunkt*/
                Console.WriteLine("Hvad er starttidspunktet? (f.eks. 12:00 eller 13:15) - kun incrementer af 15 minutter");
                DateTime starttidspunkt = Convert.ToDateTime(Console.ReadLine());
                InputKontrol.TidsKontrol(starttidspunkt);

                /*Brugervalg - tilføj - sluttidspunkt*/
                Console.WriteLine("Hvad er sluttidspunktet? (f.eks. 12:00 eller 13:15) - kun incrementer af 15 minutter");
                DateTime sluttidspunkt = Convert.ToDateTime(Console.ReadLine());
                InputKontrol.TidsKontrol(sluttidspunkt);

                /*Opretter besøgende*/
                besøgende.OpretBesøgende(navn, begrundelse, starttidspunkt, sluttidspunkt); //Opretter person besøgende objekt.
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

/*
Husk at jeg er ved at lave et mødesystem. 
Når der oprettes en bruger, så skal jeg bestemme om de er normal person, eller sekretær osv.
På den måde så kan jeg lave noget nedarvning

Så kan jeg lave en "opret møde" knap. 

Hvis mødet bliver lavet udenfor åben tid eller over en grænse, så afbryd. 

*/