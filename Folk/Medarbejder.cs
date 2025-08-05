using eksamensprojekt;
using eksamensprojekt.Folk;
using eksamensprojekt.Input;

namespace Folk
{
    public class Medarbejder : Person
    {
        //Constructor som sætter besøgendes MaxMødeTid værdi til 4
        public override TimeSpan MaxMødeTid()
        {
            return TimeSpan.FromHours(4);
        }
    }
}
