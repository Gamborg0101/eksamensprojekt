using System.ComponentModel.DataAnnotations;
using eksamensprojekt;
namespace Folk
{
  public class Besøgende : Person
  {
    
    //Constructor som sætter besøgendes MaxMødeTid værdi til 1
    public Besøgende()
    {
      MaxMødeTid = 1;
    }
  }
}