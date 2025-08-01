using System.ComponentModel.DataAnnotations;
using eksamensprojekt;
namespace Folk
{
  public class Besøgende : Person
  {
    
    //Constructor
    public Besøgende()
    {
      MaxMødeTid = 1;
    }
  }
}