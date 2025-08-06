namespace eksamensprojekt.Folk
{
    public class Medarbejder : Person
    {
        //Constructor som sætter besøgendes MaxMødeTid værdi til 4
        public override TimeSpan MaxMødeTid()
        {
            return MedarbejderFactory.besøgendeMødeTid;
        }
    }
}
