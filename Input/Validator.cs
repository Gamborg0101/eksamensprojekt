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
        int counter = 3;
        //Hvis listen er tom, så skal dette returneres med det samme
        if (besøgende.Count == 0)
        {
            Console.WriteLine("Listen er tom");
            return null;
        }
        for (int i = 0; i < 3; i++)
        {
            string id = Console.ReadLine();
            bool triedParse = int.TryParse(id, out int parsedId);
            if (triedParse)
            {
                Person sletElement = besøgende.Single(person => person.Id == parsedId);
                return sletElement;
            }
            counter--;
            
            if(counter == 0){
                Console.WriteLine($"Du har {counter} forsøg tilbage eller listen er tom");
            }
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