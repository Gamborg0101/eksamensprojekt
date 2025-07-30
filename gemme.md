// Menupunkterne laves
Menupunkter.LavMenupunkter(menupunkter);

            // Brugervalg - tilføj - menuvalg
            int menupunktValg;
            try
            {
                menupunktValg = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Skriv et gyldigt tal.");
                continue;
            }

            if (menupunktValg == (int)MenuValg.Tilføj)
            {
                Person person = null;
                /*Defination af arbejdstitel*/
                Console.WriteLine("Hvilken titel har personen?");
                Menupunkter.LavArbejdstitelPunkter(arbejdsTitler);
                int titelValg = InputKontrol.TitelKontrol(); //Eller dette?


                // try
                // {
                //     titelValg = Convert.ToInt32(Console.ReadLine());
                // }
                // catch
                // {
                //     Console.WriteLine("Skriv et gyldigt tal.");
                //     continue;
                // }

                if (titelValg == (int)ArbejdsTitler.Besøgende)
                {
                    person = new Besøgende();
                }
                else if (titelValg == (int)ArbejdsTitler.Medarbejder)
                {
                    person = new Medarbejder();
                }
                else
                {
                    Console.WriteLine("Ugyldigt titelvalg.");
                    return;
                }

                /*Brugervalg - tilføj - navn */
                string navn = InputKontrol.NavnKontrol();
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
                person.Starttidspunkt = starttidspunkt;

                /*Brugervalg - tilføj - sluttidspunkt*/
                Console.WriteLine("Hvad er sluttidspunktet? (f.eks. 12:00 eller 13:15) - kun incrementer af 15 minutter");
                DateTime sluttidspunkt = Convert.ToDateTime(Console.ReadLine());
                Tidsstyring.TidsKontrol(sluttidspunkt);
                person.Sluttidspunkt = sluttidspunkt;

                /*Kontrollere om starttidspunktet er tidligere end sluttidspunktet*/
                if (!Tidsstyring.StartogSlutTidspunkt(starttidspunkt, sluttidspunkt))
                {
                    Console.WriteLine("Starttidspunktet er senere en sluttidspunktet");
                    return;
                }
                /*Tjekker om mødetiden overskredet i forhold til deres tilladte mødetid*/
                if (!person.TjekMødeTid(starttidspunkt, sluttidspunkt))
                {
                    Console.WriteLine($"Mødetid overskrider max tilladt tid på {person.maxMødeTid} timer.");
                    return;
                }

                /*Opretter besøgende*/
                besøgende.OpretBesøgende(person); // Tilføjer personen til listen over besøgende (kan være Medarbejder eller Udefrakommende)
                Console.WriteLine("Besøgende tilføjet. \n");

            }

            /*Brugervalg - søg - */
            else if (menupunktValg == (int)MenuValg.Søg)
            {
                Console.WriteLine("Søgning ikke implementeret endnu.");
            }

            /*Brugervalg - vis - */
            else if (menupunktValg == (int)MenuValg.Vis)
            {
                besøgende.PrintBesøgende();
            }
            /*Brugervalg - afslut program*/
            else if (menupunktValg == (int)MenuValg.AfslutProgram)
            {
                Console.WriteLine("Programmet afsluttes");
                kørProgram = false;
            }
            /*Ugyldigt valg */
            else
            {
                Console.WriteLine("Ugyldigt valg.");
                continue;
            }
