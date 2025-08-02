namespace Folk;

class Validator
{
    //Kontroller string input og giver brugeren 3 forsøg
    public string LæsBrugerInputStreng()
    {
        int counter = 3;
        for (int n = 0; n < 3; n++)
        {
            
            string navn = Console.ReadLine();
            if (navn != null && navn.Length >= 2)
            {
                return navn;
            }
            counter--;
            Console.WriteLine($"Du har {counter} forsøg tilbage");
            if (counter == 0)
            {
                throw new Exception("Du har opbrugt dine forsøg.");
            }
        }
        throw new Exception("Du har opbrugt dine forsøg.");
    }

    public Person LæsBrugerIntInputSletMenu(List<Person> besøgende)
    {
        /*Der skal være en mulighed for, at brugeren kan trykke 0, og så går den en tilbage.*/
        if (besøgende.Count == 0)
        {
            Console.WriteLine("Listen er tom");
            return null;
        }
        
        int counter = 3;
        
        while(counter > 0)
        {
            Console.WriteLine("Hvilken bruger vil du slette? Brug ID");
            Console.Write("Brugervalg: ");
            string input = Console.ReadLine();
            if (input == null)
            {
                return null;
            }
            bool erValid = int.TryParse(input, out int parsedId);

            if (!erValid)
            {
                Console.WriteLine("Ugyldigt input. Indtast et tal.");
            }
            else
            {
                Person person = besøgende.FirstOrDefault(person => person.Id == parsedId); //Hvis false, returner null
                if (person != null)
                    return person;
                Console.WriteLine("Ingen person med dette ID blev fundet.");
            }
            counter--;
            Console.WriteLine($"Du har {counter} forsøg tilbage.");
        }
        throw new Exception("Du har opbrugt dine forsøg.");
    }

    //Kontrollere int input og giver brugeren 3 forsøg
    public int LæsBrugerInputIntHovedmenu()
    {
        //Kunne gøre noget med at modtage argument med menu.length, og så slette den ene metode
        int counter = 3;
        for (int n = 0; n < 3; n++)
        {
            Console.Write("Brugervalg: ");
            string value = Console.ReadLine();
            bool triedParse = int.TryParse(value, out int parsedValue);

            if (triedParse && (parsedValue == 1 || parsedValue == 2 || parsedValue == 3 || parsedValue == 4))
            {
                return parsedValue;
            }
            counter--;
            Console.WriteLine($"Ugyldigt input. Du har {counter} forsøg tilbage.");
        }
        throw new Exception("Du har opbrugt dine forsøg.");
    }
    public int LæsBrugerInputUndermenu()
    {
        {
            int counter = 3;
            for (int n = 0; n < 3; n++)
            {
                Console.Write("Brugervalg: ");
                string value = Console.ReadLine();
                bool triedParse = int.TryParse(value, out int parsedValue);

                if (triedParse && (parsedValue == 1 || parsedValue == 2))
                {
                    return parsedValue;
                }
                counter--;
                Console.WriteLine($"Ugyldigt input. Du har {counter} forsøg tilbage.");
            }
            throw new Exception("Du har opbrugt dine forsøg.");
        }
    }
}