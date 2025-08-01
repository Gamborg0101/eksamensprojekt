using Folk;

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
                Console.WriteLine("Navnet skal mindst være 2 bogstaver.");
            }
        }
        throw new Exception("Du har opbrugt dine forsøg.");
    }

    //Kontrollere int input og giver brugeren 3 forsøg
    public int LæsBrugerInputInt()
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