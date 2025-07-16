class Program
{
    static void Main()
    {
        Besøgende test1 = new Besøgende();
        Console.WriteLine(test1.sigHej());

        Styring styring = new Styring(); 
        styring.StartProgram();
    }

}
